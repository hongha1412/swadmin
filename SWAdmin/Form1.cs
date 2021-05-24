using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.BandedGrid;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraSplashScreen;
using FastMember;
using SWAdmin.TableStruct;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static SWAdmin.TableStruct.TBItemServer;

namespace SWAdmin
{
    public partial class Form1 : DevExpress.XtraBars.TabForm
    {
        private bool _reChecksumOnUpdate = false;
        Dictionary<string, BaseStruct> _supportedFiles;
        Dictionary<string, DataTable> _dataTable;
        private string _currentResPath;
        private List<string> lsRes;
        public WorkerTypeEnum _currentWork;
        public List<DXPopupMenu> _gridMenu;
        public List<string> _lsEditUnsupported = new List<string>();
        public Form1()
        {
            InitializeComponent();
            _dataTable = new Dictionary<string, DataTable>();
            tabFormControl1.SelectedPage = tabFormPage1;
            tabFormControl1.SelectedContainer = tabFormContentContainer1;
        }

        private void CreateGridMenu()
        {
            if (_gridMenu == null || _gridMenu.Count <= 0)
            {
                _gridMenu = new List<DXPopupMenu>();
                DXPopupMenu _exportMenu = new DXPopupMenu();
                _exportMenu.Caption = "Export data";
                DXMenuItem toCsv = new DXMenuItem("-> to CSV");
                DXMenuItem toTxtPlain = new DXMenuItem("-> to plain text");
                DXMenuItem toTxtTrans = new DXMenuItem("-> to text for HQTranslation");
                string FileName = lbRes.SelectedItem.ToString();
                toCsv.Click += (o, args) =>
                {
                    this.xtraSaveFileDialog.FileName = FileName + ".csv";
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToCSV(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                toTxtPlain.Click += (o, args) =>
                {
                    this.xtraSaveFileDialog.FileName = FileName + ".txt";
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToTxtPlain(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                toTxtTrans.Click += (o, args) =>
                {
                    if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        string filename = this.xtraSaveFileDialog.FileName;
                        this._dataTable[lbRes.SelectedItem.ToString().ToLower()].ToTxtTrans(filename);
                        XtraMessageBox.Show("Data exported");
                    }
                };
                DXPopupMenu _importMenu = new DXPopupMenu();
                _importMenu.Caption = "Import data";
                DXMenuItem fromCsv = new DXMenuItem("-> from CSV");
                DXMenuItem fromTxtTrans = new DXMenuItem("-> from text for HQTranslation");
                DXMenuItem fromRes = new DXMenuItem("-> from other res (Pls use same struct)");
                fromCsv.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromCsv(filename, this.splashScreenManager);
                            XtraMessageBox.Show("Data imported");
                        }
                        finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                    }
                };
                fromTxtTrans.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromTxtTrans(filename, this.splashScreenManager);
                            XtraMessageBox.Show("Data imported");
                        }
                        finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                    }
                };
                fromRes.Click += (o, args) =>
                {
                    if (gridView1.RowCount > 2000)
                    {
                        if (XtraMessageBox.Show("Data content is very large, maybe this function take along time to process, are you sure?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
                        {
                            return;
                        }
                    }
                    if (this.xtraOpenFileDialog.ShowDialog() != DialogResult.OK)
                    {
                        return;
                    }
                    if (!string.IsNullOrEmpty(this.xtraOpenFileDialog.FileName) && this._dataTable[lbRes.SelectedItem.ToString().ToLower()] != null)
                    {
                        try
                        {
                            this.splashScreenManager.ShowWaitForm();
                            string filename = this.xtraOpenFileDialog.FileName;
                            int cIndex = -1;
                            try
                            {
                                int.Parse(XtraInputBox.Show("Do you want to specify import column? (-1 for import all)", "Info", "-1"));
                            }
                            catch (Exception) { }
                            this._dataTable[lbRes.SelectedItem.ToString().ToLower()].FromRes(this.ReadResFile(filename, false), cIndex, this.splashScreenManager);
                            XtraMessageBox.Show("Data imported");
                        }
                        finally
                        {
                            this.splashScreenManager.CloseWaitForm();
                        }
                    }
                };
                _exportMenu.Items.Add(toCsv);
                _exportMenu.Items.Add(toTxtPlain);
                _exportMenu.Items.Add(toTxtTrans);
                _importMenu.Items.Add(fromCsv);
                _importMenu.Items.Add(fromTxtTrans);
                _importMenu.Items.Add(fromRes);
                _gridMenu.Add(_exportMenu);
                _gridMenu.Add(_importMenu);
            }
        }

        private void InitServerSupportedFiles()
        {
            _supportedFiles = new Dictionary<string, BaseStruct>();
            _supportedFiles.Add("tb_achievement.res", new TBAchievementServer());
            _supportedFiles.Add("tb_achievement_begin.res", new TBACHIEVEMENTBEGINServer());
            _supportedFiles.Add("tb_achievement_emblem.res", new TBACHIEVEMENTEMBLEMServer());
            _supportedFiles.Add("tb_akashic_combination.res", new TBAKASHICCOMBINATIONServer());
            _supportedFiles.Add("tb_akashic_disassemble.res", new TBAKASHICDISASSEMBLEServer());
            _supportedFiles.Add("tb_akashic_make.res", new TBAkashicMakeServer());
            _supportedFiles.Add("tb_akashic_random_group.res", new TBAKASHICRANDOMGROUPServer());
            _supportedFiles.Add("tb_akashic_random_group_in.res", new TBAKASHICRANDOMGROUPINServer());
            _supportedFiles.Add("tb_akashic_records.res", new TBAkashicRecordsServer());
            _supportedFiles.Add("tb_akashic_slot_extend.res", new TBAKASHICSLOTEXTENDServer());
            _supportedFiles.Add("tb_appearance.res", new TBAPPEARANCEServer());
            _supportedFiles.Add("tb_aura.res", new TBAURAServer());
            _supportedFiles.Add("tb_bank_slot_extend.res", new TBBANKSLOTEXTENDServer());
            _supportedFiles.Add("tb_battle_arena_info.res", new TBBATTLEARENAINFOServer());
            _supportedFiles.Add("tb_booster.res", new TBBOOSTERServer());
            _supportedFiles.Add("tb_broach_set.res", new TBBROACHSETServer());
            _supportedFiles.Add("tb_broachcompose_rank.res", new TBBROACHCOMPOSERANKServer());
            _supportedFiles.Add("tb_broachcompose_theme.res", new TBBROACHCOMPOSETHEMEServer());
            _supportedFiles.Add("tb_broachcompose_type.res", new TBBROACHCOMPOSETYPEServer());
            _supportedFiles.Add("tb_broachdata.res", new TBBROACHDATAServer());
            _supportedFiles.Add("tb_buff.res", new TBBuffServer());
            _supportedFiles.Add("tb_cashbilling_info.res", new TBCashBillingInfoServer());
            _supportedFiles.Add("tb_cashshop.res", new TBCashShopServer());
            _supportedFiles.Add("tb_cashshop_tab.res", new TBCashShopTabServer());
            _supportedFiles.Add("tb_change_mob_id.res", new TBCHANGEMOBIDServer());
            _supportedFiles.Add("tb_character_info.res", new TBCharacterInfoServer());
            _supportedFiles.Add("tb_character_parts.res", new TBCHARACTERPARTSServer());
            _supportedFiles.Add("tb_chattingcommand.res", new TBChattingCommandServer());
            _supportedFiles.Add("tb_check_access_reward.res", new TBCHECKACCESSREWARDServer());
            _supportedFiles.Add("tb_check_attendance_info.res", new TBCHECKATTENDANCEINFOServer());
            _supportedFiles.Add("tb_check_attendance_reward.res", new TBCHECKATTENDANCEREWARDServer());
            _supportedFiles.Add("tb_check_attendance_streak.res", new TBCHECKATTENDANCESTREAKServer());
            _supportedFiles.Add("tb_classbattle_role.res", new TBCLASSBATTLEROLEServer());
            _supportedFiles.Add("tb_color.res", new TBCOLORServer());
            _supportedFiles.Add("tb_combo_buff.res", new TBCOMBOBUFFServer());
            _supportedFiles.Add("tb_common.res", new tb_Common_Server());
            _supportedFiles.Add("tb_costume_socket.res", new TBCOSTUMESOCKETServer());
            _supportedFiles.Add("tb_create_cloth.res", new TBCREATECLOTHServer());
            _supportedFiles.Add("tb_createoption.res", new TBCREATEOPTIONServer());
            _supportedFiles.Add("tb_credit_raise.res", new TBCREDITRAISEServer());
            _supportedFiles.Add("tb_cultivation.res", new TBCULTIVATIONServer());
            _supportedFiles.Add("tb_customer_benefit.res", new TBCUSTOMERBENEFITServer());
            _supportedFiles.Add("tb_customer_grade.res", new TBCUSTOMERGRADEServer());
            _supportedFiles.Add("tb_daily_mission.res", new TBDailyMissionServer());
            _supportedFiles.Add("tb_dailymaze_portal.res", new TBDAILYMAZEPORTALServer());
            _supportedFiles.Add("tb_day_event.res", new TBDayEventServer());
            _supportedFiles.Add("tb_day_event_booster.res", new TBDAYEVENTBOOSTERServer());
            _supportedFiles.Add("tb_deck_bonus.res", new TBDECKBONUSServer());
            _supportedFiles.Add("tb_defensive_weapon.res", new TBDEFENSIVEWEAPONServer());
            _supportedFiles.Add("tb_disassemble.res", new TBDISASSEMBLEServer());
            _supportedFiles.Add("tb_district.res", new TBDISTRICTServer());
            _supportedFiles.Add("tb_district_transport.res", new TBDISTRICTTRANSPORTServer());
            _supportedFiles.Add("tb_divergence.res", new TBDIVERGENCEServer());
            _supportedFiles.Add("tb_divisionrankreward.res", new TBDIVISIONRANKREWARDServer());
            _supportedFiles.Add("tb_drop.res", new TBDropServer());
            _supportedFiles.Add("tb_drop_group.res", new TBDropGroupServer());
            _supportedFiles.Add("tb_drop_group_character.res", new TBDropGroupCharacterServer());
            _supportedFiles.Add("tb_droprate_level.res", new TBDROPRATELEVELServer());
            _supportedFiles.Add("tb_droprate_member.res", new TBDROPRATEMEMBERServer());
            _supportedFiles.Add("tb_droprate_mob.res", new TBDROPRATEMOBServer());
            _supportedFiles.Add("tb_ds_point.res", new TBDSPOINTServer());
            _supportedFiles.Add("tb_dye.res", new TBDYEServer());
            _supportedFiles.Add("tb_dye_info.res", new TBDYEINFOServer());
            _supportedFiles.Add("tb_echelon.res", new TBEchelonServer());
            _supportedFiles.Add("tb_equalizer_info.res", new TBEqualizerInfoServer());
            _supportedFiles.Add("tb_event_condition.res", new TBEVENTCONDITIONServer());
            _supportedFiles.Add("tb_faction.res", new TBFACTIONServer());
            _supportedFiles.Add("tb_fragment_exchange.res", new TBFRAGMENTEXCHANGEServer());
            _supportedFiles.Add("tb_fragment_extraction.res", new TBFRAGMENTEXTRACTIONServer());
            _supportedFiles.Add("tb_gacha_group.res", new TBGACHAGROUPServer());
            _supportedFiles.Add("tb_gear_rate.res", new TBGEARRATEServer());
            _supportedFiles.Add("tb_gesture.res", new TBGESTUREServer());
            _supportedFiles.Add("tb_helper.res", new TBHELPERServer());
            _supportedFiles.Add("tb_helper_reward.res", new TBHELPERREWARDServer());
            _supportedFiles.Add("tb_hidden_event.res", new TBHIDDENEVENTServer());
            _supportedFiles.Add("tb_infinite_tower.res", new TBINFINITETOWERServer());
            _supportedFiles.Add("tb_interaction_item.res", new TBINTERACTIONITEMServer());
            _supportedFiles.Add("tb_interaction_object.res", new TBINTERACTIONOBJECTServer());
            _supportedFiles.Add("tb_inven_slot_extend.res", new TBINVENSLOTEXTENDServer());
            _supportedFiles.Add("tb_item.res", new TBItemServer());
            _supportedFiles.Add("tb_item_classify.res", new TBItemClassifyServer());
            _supportedFiles.Add("tb_item_classreward_link.res", new TBITEMCLASSREWARDLINKServer());
            _supportedFiles.Add("tb_item_costumeset.res", new TBITEMCOSTUMESETServer());
            _supportedFiles.Add("tb_item_countbox.res", new TBITEMCOUNTBOXServer());
            _supportedFiles.Add("tb_item_countbox_group.res", new TBITEMCOUNTBOXGROUPServer());
            _supportedFiles.Add("tb_item_endurance.res", new TBITEMENDURANCEServer());
            _supportedFiles.Add("tb_item_evolution.res", new TBItemEvolutionServer());
            _supportedFiles.Add("tb_item_extraction.res", new TBITEMEXTRACTIONServer());
            _supportedFiles.Add("tb_item_limit.res", new TBITEMLIMITServer());
            _supportedFiles.Add("tb_item_package.res", new TBITEMPACKAGEServer());
            _supportedFiles.Add("tb_item_randombox.res", new TBItemRandomBoxServer());
            _supportedFiles.Add("tb_item_rank_rate.res", new TBITEMRANKRATEServer());
            _supportedFiles.Add("tb_item_repair.res", new TBITEMREPAIRServer());
            _supportedFiles.Add("tb_item_script.res", new TBITEMSCRIPTServer());
            _supportedFiles.Add("tb_item_setitem.res", new TBITEMSETITEMServer());
            _supportedFiles.Add("tb_item_similargroup.res", new TBITEMSIMILARGROUPServer());
            _supportedFiles.Add("tb_item_title.res", new TBITEMTITLEServer());
            _supportedFiles.Add("tb_item_title_change.res", new TBITEMTITLECHANGEServer());
            _supportedFiles.Add("tb_item_title_group.res", new TBITEMTITLEGROUPServer());
            _supportedFiles.Add("tb_item_title_value.res", new TBITEMTITLEVALUEServer());
            _supportedFiles.Add("tb_league_info.res", new TBLEAGUEINFOServer());
            _supportedFiles.Add("tb_league_skill.res", new TBLEAGUESKILLServer());
            _supportedFiles.Add("tb_level_mail.res", new TBLEVELMAILServer());
            _supportedFiles.Add("tb_levelup_point.res", new TBLEVELUPPOINTServer());
            _supportedFiles.Add("tb_make.res", new TBMAKEServer());
            _supportedFiles.Add("tb_maze_enter_count_group.res", new TBMAZEENTERCOUNTGROUPServer());
            _supportedFiles.Add("tb_maze_info.res", new TBMazeInfoServer());
            _supportedFiles.Add("tb_maze_open_group.res", new TBMazeOpenGroupServer());
            _supportedFiles.Add("tb_maze_opencontrol.res", new TBMazeOpenControlServer());
            _supportedFiles.Add("tb_mazereward_difficulty.res", new TBMAZEREWARDDIFFICULTYServer());
            _supportedFiles.Add("tb_mazereward_item.res", new TBMazeRewardItemServer());
            _supportedFiles.Add("tb_mazereward_level.res", new TBMAZEREWARDLEVELServer());
            _supportedFiles.Add("tb_mazereward_normal.res", new TBMAZEREWARDNORMALServer());
            _supportedFiles.Add("tb_mazereward_partyvalue.res", new TBMAZEREWARDPARTYVALUEServer());
            _supportedFiles.Add("tb_mazereward_rank.res", new TBMAZEREWARDRANKServer());
            _supportedFiles.Add("tb_mazereward_revision.res", new TBMAZEREWARDREVISIONServer());
            _supportedFiles.Add("tb_mazereward_soulvaper.res", new TBMAZEREWARDSOULVAPERServer());
            _supportedFiles.Add("tb_mazereward_standard.res", new TBMAZEREWARDSTANDARDServer());
            _supportedFiles.Add("tb_mazereward_time.res", new TBMAZEREWARDTIMEServer());
            _supportedFiles.Add("tb_mileage.res", new TBMILEAGEServer());
            _supportedFiles.Add("tb_mode_bi_class_correction.res", new TBMODEBICLASSCORRECTIONServer());
            _supportedFiles.Add("tb_mode_bi_class_startskill.res", new TBMODEBICLASSSTARTSKILLServer());
            _supportedFiles.Add("tb_mode_bi_reward.res", new TBMODEBIREWARDServer());
            _supportedFiles.Add("tb_mode_bi_sector_info.res", new TBMODEBISECTORINFOServer());
            _supportedFiles.Add("tb_mode_bi_skill_edit.res", new TBMODEBISKILLEDITServer());
            _supportedFiles.Add("tb_mode_bi_upgrade.res", new TBMODEBIUPGRADEServer());
            _supportedFiles.Add("tb_mode_bi_upgrade_group.res", new TBMODEBIUPGRADEGROUPServer());
            _supportedFiles.Add("tb_mode_cardmatch_card.res", new TBMODECARDMATCHCARDServer());
            _supportedFiles.Add("tb_mode_cardmatch_rule.res", new TBMODECARDMATCHRULEServer());
            _supportedFiles.Add("tb_mode_defence.res", new TBMODEDEFENCEServer());
            _supportedFiles.Add("tb_mode_district6.res", new TBMODEDISTRICT6Server());
            _supportedFiles.Add("tb_mode_district6_date.res", new TBMODEDISTRICT6DATEServer());
            _supportedFiles.Add("tb_mode_operation.res", new TBMODEOPERATIONServer());
            _supportedFiles.Add("tb_mode_survival.res", new TBMODESURVIVALServer());
            _supportedFiles.Add("tb_monster.res", new TBMonsterServer());
            _supportedFiles.Add("tb_monster_broken_parts.res", new TBMONSTERBROKENPARTSServer());
            _supportedFiles.Add("tb_monster_exp.res", new TBMONSTEREXPServer());
            _supportedFiles.Add("tb_monster_parts.res", new TBMONSTERPARTSServer());
            _supportedFiles.Add("tb_monster_weapon.res", new TBMONSTERWEAPONServer());
            _supportedFiles.Add("tb_myroom_furniture.res", new TBMYROOMFURNITUREServer());
            _supportedFiles.Add("tb_myroom_greed.res", new TBMYROOMGREEDServer());
            _supportedFiles.Add("tb_myroom_info.res", new TBMYROOMINFOServer());
            _supportedFiles.Add("tb_namefilter.res", new TBNAMEFILTERServer());
            _supportedFiles.Add("tb_npc.res", new TBNPCServer());
            _supportedFiles.Add("tb_npc_parts.res", new TBNPCPARTSServer());
            _supportedFiles.Add("tb_operation_info.res", new TBOPERATIONINFOServer());
            _supportedFiles.Add("tb_option_string.res", new TBOPTIONSTRINGServer());
            _supportedFiles.Add("tb_partyexp_level.res", new TBPARTYEXPLEVELServer());
            _supportedFiles.Add("tb_partyexp_member.res", new TBPARTYEXPMEMBERServer());
            _supportedFiles.Add("tb_partyexp_mob.res", new TBPARTYEXPMOBServer());
            _supportedFiles.Add("tb_partyrevise.res", new TBPARTYREVISEServer());
            _supportedFiles.Add("tb_pc_akashic.res", new TBPCAKASHICServer());
            _supportedFiles.Add("tb_pc_costume.res", new TBPCCOSTUMEServer());
            _supportedFiles.Add("tb_pc_reward_system.res", new TBPCREWARDSYSTEMServer());
            _supportedFiles.Add("tb_pc_reward_system_month.res", new TBPCREWARDSYSTEMMONTHServer());
            _supportedFiles.Add("tb_photo_item.res", new TBPhotoItemServer());
            _supportedFiles.Add("tb_pollen.res", new TBPOLLENServer());
            _supportedFiles.Add("tb_provide_item.res", new TBPROVIDEITEMServer());
            _supportedFiles.Add("tb_quest_chapter.res", new TBQUESTCHAPTERServer());
            _supportedFiles.Add("tb_quest_condition.res", new TBQUESTCONDITIONServer());
            _supportedFiles.Add("tb_quest_episode.res", new tb_Quest_Episode_Server());
            _supportedFiles.Add("tb_quest_reward.res", new TBQUESTREWARDServer());
            _supportedFiles.Add("tb_quest_season.res", new TBQUESTSEASONServer());
            _supportedFiles.Add("tb_random_change.res", new TBRANDOMCHANGEServer());
            _supportedFiles.Add("tb_random_get.res", new TBRANDOMGETServer());
            _supportedFiles.Add("tb_random_get_group.res", new TBRANDOMGETGROUPServer());
            _supportedFiles.Add("tb_random_option.res", new TBRANDOMOPTIONServer());
            _supportedFiles.Add("tb_rank_change.res", new TBRANKCHANGEServer());
            _supportedFiles.Add("tb_rank_info.res", new TBRANKINFOServer());
            _supportedFiles.Add("tb_rank_reward.res", new TBRANKREWARDServer());
            _supportedFiles.Add("tb_rank_reward_totalpoint.res", new TBRANKREWARDTOTALPOINTServer());
            _supportedFiles.Add("tb_reinforce.res", new TBReinforceServer());
            _supportedFiles.Add("tb_reinforce_exchange.res", new TBREINFORCEEXCHANGEServer());
            _supportedFiles.Add("tb_reinforce_option.res", new TBREINFORCEOPTIONServer());
            _supportedFiles.Add("tb_repackagecostume.res", new TBREPACKAGECOSTUMEServer());
            _supportedFiles.Add("tb_roomrank_reward.res", new TBROOMRANKREWARDServer());
            _supportedFiles.Add("tb_sectorquest.res", new TBSECTORQUESTServer());
            _supportedFiles.Add("tb_select_item.res", new TBSELECTITEMServer());
            _supportedFiles.Add("tb_serverinfo.res", new TBServerInfoServer());
            _supportedFiles.Add("tb_shop.res", new TBShopServer());
            _supportedFiles.Add("tb_skill.res", new TBSKILLServer());
            _supportedFiles.Add("tb_skill_action.res", new TBSKILLACTIONServer());
            _supportedFiles.Add("tb_skill_option.res", new TBSKILLOPTIONServer());
            _supportedFiles.Add("tb_skill_slot_extend.res", new TBSKILLSLOTEXTENDServer());
            _supportedFiles.Add("tb_social_item.res", new TBSOCIALITEMServer());
            _supportedFiles.Add("tb_social_motion.res", new TBSOCIALMOTIONServer());
            _supportedFiles.Add("tb_socket.res", new TBSOCKETServer());
            _supportedFiles.Add("tb_soul_guage.res", new TBSOULGUAGEServer());
            _supportedFiles.Add("tb_soul_metry.res", new TBSOULMETRYServer());
            _supportedFiles.Add("tb_soulstone_levelup.res", new TBSOULSTONELEVELUPServer());
            _supportedFiles.Add("tb_spawn_group.res", new TBSPAWNGROUPServer());
            _supportedFiles.Add("tb_spawnbox_frontline_01.res", new TBSPAWNBOXFRONTLINE01Server());
            _supportedFiles.Add("tb_spawnbox_rsquare_01.res", new TBSPAWNBOXRSQUARE01Server());
            _supportedFiles.Add("tb_specialmaze_open.res", new TBSpecialMazeOpenServer());
            _supportedFiles.Add("tb_status.res", new TBSTATUSServer());
            _supportedFiles.Add("tb_systemmail.res", new TBSYSTEMMAILServer());
            _supportedFiles.Add("tb_systemmail_add.res", new TBSYSTEMMAILADDServer());
            _supportedFiles.Add("tb_talk.res", new TBTALKServer());
            _supportedFiles.Add("tb_talk_list.res", new TBTALKLISTServer());
            _supportedFiles.Add("tb_talk_string.res", new TBTALKSTRINGServer());
            _supportedFiles.Add("tb_title_info.res", new TBTITLEINFOServer());
            _supportedFiles.Add("tb_title_reward.res", new TBTITLEREWARDServer());
            _supportedFiles.Add("tb_title_string.res", new TBTITLESTRINGServer());
            _supportedFiles.Add("tb_transport_info.res", new TBTRANSPORTINFOServer());
            _supportedFiles.Add("tb_unity_event.res", new TBUNITYEVENTServer());
            _supportedFiles.Add("tb_version.res", new TBVERSIONServer());
            _supportedFiles.Add("tb_warlord_event.res", new TBWARLORDEVENTServer());
            _supportedFiles.Add("tb_warlord_gui.res", new TBWARLORDGUIServer());
            _supportedFiles.Add("tb_weapon_rate.res", new TBWEAPONRATEServer());
            _supportedFiles.Add("tb_week_day.res", new TBWeekDayServer());
            _supportedFiles.Add("tb_week_group.res", new TBWEEKGROUPServer());
            _supportedFiles.Add("tb_week_mission.res", new TBWEEKMISSIONServer());
            _supportedFiles.Add("tb_world_event.res", new TBWORLDEVENTServer());
            _supportedFiles.Add("tb_world_event_reward.res", new TBWORLDEVENTREWARDServer());
            _supportedFiles.Add("tb_slot_extend.res", new TBSLOTEXTENDServer());
            _supportedFiles.Add("tb_monster_spawn.res", new TBMONSTERSPAWNServer());
        }
        private void InitClientSupportedFiles()
        {
            _supportedFiles = new Dictionary<string, BaseStruct>();
            _supportedFiles.Add("tb_item.res", new TBItemClient());
            _supportedFiles.Add("tb_shop.res", new TBShopClient());
            _supportedFiles.Add("tb_cashshop.res", new TBCashShopClient());
            _supportedFiles.Add("tb_cashbilling_info.res", new TBCashBillingInfoClient());
            _supportedFiles.Add("tb_achievement.res", new TBAchievementClient());
            _supportedFiles.Add("tb_achievement_script.res", new TBAchievementScriptClient());
            _supportedFiles.Add("tb_item_script.res", new TBItemScriptClient());
            _supportedFiles.Add("tb_quest_script.res", new TBQuestScriptClient());
            _supportedFiles.Add("tb_character_parts.res", new TBCharacterPartsClient());
            _supportedFiles.Add("tb_appearance.res", new TBAppearanceClient());
            _supportedFiles.Add("tb_loading_img.res", new TBLoadingImgClient());
            _supportedFiles.Add("tb_mazereward_golddirect.res", new TBMazeRewardGoldDirectClient());
            _supportedFiles.Add("tb_namefilter.res", new TBNameFilterClient());
            _supportedFiles.Add(ToLow("tb_Speech.res"), new TBSpeechClient());
            _supportedFiles.Add(ToLow("tb_Speech_tag.res"), new TBSpeechTagClient());
            _supportedFiles.Add(ToLow("tb_Skill_Script.res"), new TBSkillScriptClient());
            _supportedFiles.Add(ToLow("tb_ChattingCommand.res"), new TBChattingCommandClient());
            _supportedFiles.Add(ToLow("Tb_Akashic_Slot_Extend.res"), new Tb_Akashic_Slot_Extend_Client());
            _supportedFiles.Add(ToLow("tb_Booster_Script.res"), new tb_Booster_Script_Client());
            _supportedFiles.Add(ToLow("tb_Buff_Script.res"), new tb_Buff_Script_Client());
            _supportedFiles.Add(ToLow("tb_SystemMail.res"), new tb_SystemMail_Client());
            _supportedFiles.Add(ToLow("tb_UI_String.res"), new tb_UI_String_Client());
            _supportedFiles.Add(ToLow("tb_Booster.res"), new tb_Booster_Client());
            _supportedFiles.Add(ToLow("tb_Class_Speech.res"), new tb_Class_Speech_Client());
            _supportedFiles.Add(ToLow("tb_Skill.res"), new tb_Skill_Client());
            _supportedFiles.Add(ToLow("tb_soul_metry.res"), new tb_soul_metry_Client());
            _supportedFiles.Add(ToLow("tb_Talk.res"), new tb_Talk_Client());
            _supportedFiles.Add(ToLow("tb_Talk_List.res"), new tb_Talk_List_Client());
            _supportedFiles.Add(ToLow("tb_Title_Info.res"), new tb_Title_Info_Client());
            _supportedFiles.Add(ToLow("tb_Aura.res"), new tb_Aura_Client());
            _supportedFiles.Add(ToLow("tb_Cinema_String.res"), new tb_Cinema_String_Client());
            _supportedFiles.Add(ToLow("tb_Class_form.res"), new tb_Class_form_Client());
            _supportedFiles.Add(ToLow("tb_Common.res"), new tb_Common_Client());
            _supportedFiles.Add(ToLow("tb_Achievement_begin.res"), new tb_Achievement_begin_Client());
            _supportedFiles.Add(ToLow("tb_Maze_Info.res"), new tb_Maze_Info_Client());
            _supportedFiles.Add(ToLow("tb_Quest_Episode.res"), new tb_Quest_Episode_Client());
            _supportedFiles.Add(ToLow("tb_Character_Info.res"), new tb_Character_Info_Client());
            _supportedFiles.Add(ToLow("tb_change_tab.res"), new tb_change_tab_Client());
            _supportedFiles.Add(ToLow("tb_Equalizer_Info.res"), new tb_Equalizer_Info_Client());
            _supportedFiles.Add(ToLow("tb_SFX_BattleMaterial.res"), new tb_SFX_BattleMaterial_Client());
            _supportedFiles.Add(ToLow("tb_Defensive_Weapon.res"), new tb_Defensive_Weapon_Client());
            _supportedFiles.Add(ToLow("tb_PC_Reward_System_Month.res"), new tb_PC_Reward_System_Month_Client());
            _supportedFiles.Add(ToLow("tb_Notice.res"), new tb_Notice_Client());
            _supportedFiles.Add(ToLow("tb_PC_Akashic.res"), new tb_PC_Akashic_Client());
            _supportedFiles.Add(ToLow("tb_PC_Costume.res"), new tb_PC_Costume_Client());
            _supportedFiles.Add("tb_npc.res", new TBNPCClient());
            _supportedFiles.Add("tb_akashic_records.res", new TBAkashicRecordsClient());
            _supportedFiles.Add("tb_akashic_make.res", new TBAkashicMakeClient());
            _supportedFiles.Add("tb_buff.res", new TBBuffClient());
            _supportedFiles.Add("tb_random_get.res", new TBRandomGetClient());
            _supportedFiles.Add("tb_title_string.res", new TBTitleStringClient());
            _supportedFiles.Add("tb_speech_string.res", new TBSpeechStringClient());
            _supportedFiles.Add(ToLow("tb_Dye.res"), new tb_Dye_Client());
            _supportedFiles.Add(ToLow("tb_Item_SetItem.res"), new tb_Item_SetItem_Client());
        }
        string ToLow(string input)
        {
            return input.ToString().ToLower();
        }
        void OnOuterFormCreating(object sender, OuterFormCreatingEventArgs e)
        {
            Form1 form = new Form1();
            form.TabFormControl.Pages.Clear();
            e.Form = form;
            OpenFormCount++;
        }
        static int OpenFormCount = 1;

        private void btnLoadServerRes_Click(object sender, EventArgs e)
        {
            this.lbRes.DataSource = null;
            bgWorker.RunWorkerAsync(new WorkerArg(WorkerTypeEnum.LOAD_SERVER_RES, txtServerRes.Text));
        }

        private void btnLoadClientRes_Click(object sender, EventArgs e)
        {
            this.lbRes.DataSource = null;
            bgWorker.RunWorkerAsync(new WorkerArg(WorkerTypeEnum.LOAD_CLIENT_RES, txtClientRes.Text));
        }

        private void bgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (!this.splashScreenManager.IsSplashFormVisible)
            {
                this.splashScreenManager.ShowWaitForm();
            }
            WorkerArg arg = (WorkerArg)e.Argument;
            if (arg.WorkerType == WorkerTypeEnum.LOAD_SERVER_RES || arg.WorkerType == WorkerTypeEnum.LOAD_CLIENT_RES)
            {
                this._currentWork = arg.WorkerType;
                this._gridMenu = null;
                this.LoadResDir(arg.WorkerType, arg.WorkerType == WorkerTypeEnum.LOAD_SERVER_RES ? txtServerRes.Text : txtClientRes.Text);
            }
            else if (arg.WorkerType == WorkerTypeEnum.LOAD_RES)
            {
                this.LoadResData(arg.ArgValue.ToString());
                this.CreateGridMenu();
                // Prevent export data to txt HQTrans for server
                if (this._currentWork == WorkerTypeEnum.LOAD_SERVER_RES && _gridMenu.Count > 0 && _gridMenu[0].Items.Count > 0)
                {
                    _gridMenu[0].Items.RemoveAt(_gridMenu[0].Items.Count - 1);
                }
            }
            else if (arg.WorkerType == WorkerTypeEnum.SAVE_RES)
            {
                this.SaveResData();
            }
            else if (arg.WorkerType == WorkerTypeEnum.TRANSLATE)
            {
            }
            if (this.splashScreenManager.IsSplashFormVisible)
            {
                this.splashScreenManager.CloseWaitForm();
            }
        }

        private void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private void LoadResData(string filePath)
        {
            string filename = lbRes.SelectedItem.ToString().ToLower();
            var structdata = _supportedFiles[filename];
            if (structdata._checksum <= 0)
            {
                SWReader reader = new SWReader(filePath);
                try
                {
                    reader.readObject(structdata);
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                }
                structdata.ResetChecksum();
                structdata.calcChecksum();
            }

            object[] a = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
            List<object> list = new List<object>(a);
            if (!_dataTable.ContainsKey(filename))
            {
                _dataTable.Add(filename, list.ToDataTable(a.GetType().GetElementType()));
            }

            Invoke(new Action(() =>
            {
                gridControl1.DataSource = _dataTable[filename];
                gridView1.BestFitColumns();
            }));
        }

        private void TabContentClear()
        {
            this.lbRes.DataSource = null;
            this.gridControl1.DataSource = null;
            this.lbRes.Items.Clear();
            this.gridView1.Columns.Clear();
            this._gridMenu = null;
        }

        private void LoadResDir(WorkerTypeEnum workerType, string resPath)
        {
            if (workerType == WorkerTypeEnum.LOAD_SERVER_RES)
            {
                this.InitServerSupportedFiles();
            }
            else if (workerType == WorkerTypeEnum.LOAD_CLIENT_RES)
            {
                this.InitClientSupportedFiles();
            }
            if (string.IsNullOrEmpty(resPath))
            {
                XtraMessageBox.Show((workerType == WorkerTypeEnum.LOAD_SERVER_RES ? "Server" : "Client") + " res path is empty");
                return;
            }
            DirectoryInfo di = new DirectoryInfo(resPath);
            if (!di.Exists)
            {
                XtraMessageBox.Show((workerType == WorkerTypeEnum.LOAD_SERVER_RES ? "Server" : "Client") + " res path invalid");
                return;
            }
            FileInfo[] files = di.GetFiles("*.res");
            if (files.Length <= 0)
            {
                XtraMessageBox.Show("No res file found");
                return;
            }
            Invoke(new Action(() =>
            {
                lbRes.Items.Clear();
            }));
            lsRes = new List<string>();
            foreach (FileInfo fi in files)
            {
                if (this._supportedFiles.ContainsKey(fi.Name.ToLower()))
                {
                    lsRes.Add(fi.Name);
                }
            }
            this._currentResPath = resPath;
            Invoke(new Action(() =>
            {
                lbRes.DataSource = lsRes;
                tabFormContentContainer2.Visible = true;
                tabFormPage2.Visible = true;
                tabFormControl1.SelectedPage = tabFormPage2;
                tabFormControl1.SelectedContainer = tabFormContentContainer2;
                barbtnSave.Visibility = BarItemVisibility.Always;
            }));
        }

        private void SaveResData()
        {
            if (gridControl1.DataSource != null && !string.IsNullOrEmpty(_currentResPath))
            {
                string filename = lbRes.SelectedItem.ToString().ToLower();
                if (!_dataTable.ContainsKey(filename) || !_supportedFiles.ContainsKey(filename))
                {
                    XtraMessageBox.Show("Data table not have selected item???");
                    return;
                }
                if (!string.IsNullOrEmpty(this.xtraSaveFileDialog.FileName))
                {
                    Type type = _supportedFiles[filename].GetType();
                    List<object> lsObj = this.ConvertDataTableToList(_dataTable[filename], type.GetField("lsData").FieldType.GetElementType());
                    BaseStruct exportObj = Activator.CreateInstance(type) as BaseStruct;
                    Array arrData = Array.CreateInstance(type.GetField("lsData").FieldType.GetElementType(), lsObj.Count);
                    for (int i = 0; i < lsObj.Count; i++)
                    {
                        arrData.SetValue(lsObj[i], i);
                    }
                    type.GetField("lsData").SetValue(exportObj, arrData);
                    exportObj.ResetChecksum();
                    exportObj.calcChecksum();
                    exportObj.CreateMD5();
                    SWWriter writer = new SWWriter(this.xtraSaveFileDialog.FileName);
                    writer.writeObject(exportObj);
                    writer.flush();
                    XtraMessageBox.Show("Saved");
                }
            }
        }

        private void lbRes_SelectedIndexChanged(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            gridView1.Columns.Clear();
            if (lbRes == null || lbRes.SelectedItem == null || !_supportedFiles.ContainsKey(lbRes.SelectedItem.ToString().ToLower()))
            {
                return;
            }
            this.ReadResFile(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()), true);
        }

        private DataTable ReadResFile(string filepath, bool isAsync)
        {
            FileInfo fi = new FileInfo(filepath);
            if (this._lsEditUnsupported.Contains(fi.Name.ToLower()))
            {
                XtraMessageBox.Show(fi.Name + " is view only, checksum currently not work", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            if (!fi.Exists)
            {
                XtraMessageBox.Show("Res file not found");
                return null;
            }
            if (isAsync)
            {
                WorkerArg arg = new WorkerArg(WorkerTypeEnum.LOAD_RES, fi.FullName);
                if (bgWorker.IsBusy)
                {
                    this.CreateWorkerInstance();
                }
                bgWorker.RunWorkerAsync(arg);
            }
            else
            {
                string filename = fi.Name.ToLower();
                var structdata = _supportedFiles[filename];
                if (structdata._checksum <= 0)
                {
                    SWReader reader = new SWReader(filepath);
                    try
                    {
                        reader.readObject(structdata);
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    structdata.ResetChecksum();
                    structdata.calcChecksum();
                }

                object[] a = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
                List<object> list = new List<object>(a);
                return list.ToDataTable(a.GetType().GetElementType());
            }
            return null;
        }

        private void CreateWorkerInstance()
        {
            bgWorker = new BackgroundWorker();
            bgWorker.DoWork += new DoWorkEventHandler(bgWorker_DoWork);
        }

        private void gridControl1_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
        }

        private void barbtnSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.xtraSaveFileDialog.FileName = lbRes.SelectedItem.ToString();
            if (this.xtraSaveFileDialog.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            WorkerArg workerArg = new WorkerArg(WorkerTypeEnum.SAVE_RES, null);
            this.bgWorker.RunWorkerAsync(workerArg);
        }

        private void gridView1_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (!_reChecksumOnUpdate)
            {
                return;
            }
            // To prevent paste from clipboard
            if (e.RowHandle < 0)
            {
                return;
            }
            // To re-calculate checksum
            // Get original checksum value
            FileInfo fi = new FileInfo(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()));
            if (!_supportedFiles.ContainsKey(fi.Name.ToLower()))
            {
                XtraMessageBox.Show("Idk how but error");
                return;
            }
            var structdata = _supportedFiles[fi.Name.ToLower()];
            var lsData = structdata.GetType().GetField("lsData").GetValue(structdata) as object[];
            if (lsData.Length <= e.RowHandle)
            {
                XtraMessageBox.Show("By someway, it's make error");
                return;
            }
            var fields = lsData[e.RowHandle].GetType().GetFields();
            if (fields.Length < e.Column.AbsoluteIndex)
            {
                XtraMessageBox.Show("Wtf did you do to make this error?");
                return;
            }
            var originalValueField = fields[e.Column.AbsoluteIndex];
            Int64 originalChecksum = this.GetChecksum(originalValueField.GetValue(lsData[e.RowHandle]));
            if (originalChecksum < 0)
            {
                BandedGridView view = sender as BandedGridView;
                view.SetRowCellValue(e.RowHandle, e.Column.FieldName, originalValueField.GetValue(lsData[e.RowHandle]));
                XtraMessageBox.Show("Not allow to update data here");
                return;
            }
            // Re-calculate checksum
            if (!_dataTable.ContainsKey(fi.Name.ToLower()))
            {
                XtraMessageBox.Show("Dahell is this error?");
                return;
            }
            Int64 newChecksum = this.GetChecksum(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle][e.Column.AbsoluteIndex]);
            // Set checksum value
            _dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"] = Convert.ToInt64(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"]) - originalChecksum;
            _dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"] = Convert.ToInt64(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle]["_checksum"]) + newChecksum;
            // Re-offset
            if ("String".Equals(originalValueField.FieldType.Name))
            {
                //long adjust = Encoding.Unicode.GetBytes(_dataTable[fi.Name.ToLower()].Rows[e.RowHandle][e.Column.AbsoluteIndex].ToString()).Length -
                //    Encoding.Unicode.GetBytes(originalValueField.GetValue(lsData[e.RowHandle]).ToString()).Length;
                //this.ReOffset(adjust, e.RowHandle + 1, fi.Name.ToLower(), lsData);
            }
        }

        private void ReOffset(long adjust, int startIndex, string dtKey, object[] lsRefData)
        {
            long offset;
            for (int i = startIndex; i < _dataTable[dtKey].Rows.Count; i++)
            {
                offset = (long)lsRefData[i].GetType().GetField("_offset").GetValue(lsRefData[i]);
                _dataTable[dtKey].Rows[i]["_offset"] = offset + adjust;
            }
        }

        private Int64 GetChecksum(object originalValue)
        {
            Int64 originalChecksum = 0;
            Type type = originalValue.GetType();
            switch (type.Name)
            {
                case "Double":
                case "UInt16":
                case "UInt32":
                case "UInt64":
                case "Int16":
                case "Int32":
                case "Int64":
                case "Byte":
                case "Single":
                case "Boolean":
                    originalChecksum += Convert.ToInt64(originalValue);
                    break;
                case "String":
                    byte[] ss = Encoding.Unicode.GetBytes((string)originalValue);
                    originalChecksum += (ss.Length / 2);
                    foreach (byte b in ss)
                    {
                        originalChecksum += b;
                    }
                    break;
                default:
                    originalChecksum = -1;
                    break;
            }

            return originalChecksum;
        }

        private List<object> ConvertDataTableToList(DataTable dt, Type type)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                .Select(c => c.ColumnName)
                .ToList();

            var fields = type.GetFields();

            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance(type);

                foreach (var field in fields)
                {
                    if (columnNames.Contains(field.Name))
                        field.SetValue(objT, row[field.Name]);
                }

                return objT;
            }).ToList();

        }

        private void gridControl1_ProcessGridKey(object sender, KeyEventArgs e)
        {
            var grid = sender as GridControl;
            var view = grid.FocusedView as GridView;
            if (e.KeyData == Keys.Delete)
            {
                //long adjust = 0;
                string filename = lbRes.SelectedItem.ToString().ToLower();
                foreach (int rowid in view.GetSelectedRows().OrderByDescending(c => c))
                {
                    //adjust += ((long)_dataTable[filename].Rows[rowid + 1]["_offset"] - (long)_dataTable[filename].Rows[rowid]["_offset"]);
                    _dataTable[filename].Rows[rowid].Delete();
                    //this.ReOffset(adjust, rowid, filename, _supportedFiles[filename].GetType().GetField("lsData").GetValue(_supportedFiles[filename]) as object[]);
                }
                // view.DeleteSelectedRows();
                e.Handled = true;
            }
        }

        private void gridView1_ClipboardRowPasting(object sender, ClipboardRowPastingEventArgs e)
        {
            try
            {
                string filename = lbRes.SelectedItem.ToString().ToLower();
                Type type = _supportedFiles[filename].GetType().GetField("lsData").FieldType.GetElementType();
                var columnNames = _dataTable[filename].Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
                var dr = e.OriginalValues;
                var objT = Activator.CreateInstance(type) as BaseStruct;

                foreach (var field in type.GetFields())
                {
                    if (columnNames.Contains(field.Name) && !e.Values[field.Name].GetType().IsAssignableFrom(typeof(DBNull)))
                        field.SetValue(objT, Convert.ChangeType(e.Values[field.Name], field.FieldType));
                }

                object[] arrData = _supportedFiles[filename].GetType().GetField("lsData").GetValue(_supportedFiles[filename]) as object[];
                Array setter = Array.CreateInstance(type, arrData.Length + 1);
                for (int i = 0; i < arrData.Length; i++)
                {
                    setter.SetValue(arrData[i], i);
                }
                setter.SetValue(objT, arrData.Length);
                _supportedFiles[filename].GetType().GetField("lsData").SetValue(_supportedFiles[filename], setter);
            }
            catch (Exception)
            {
                return;
            }
        }

        private void lbRes_MouseDown(object sender, MouseEventArgs e)
        {
            this.lbRes_SelectedIndexChanged(sender, e);
        }

        private void gridView1_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            if (e.MenuType == GridMenuType.Row)
            {
                if (_gridMenu != null && _gridMenu.Count > 0)
                {
                    _gridMenu.ForEach(menu =>
                    {
                        e.Menu.Items.Add(menu);
                    });
                }
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (tabFormControl1.SelectedPage == tabFormPage2 && tabFormControl1.SelectedContainer == tabFormContentContainer2)
            {
                if (keyData == (Keys.Control | Keys.Shift | Keys.T))
                {
                    try
                    {
                        this.TranslateCell();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show(ex.Message);
                    }
                    return true;
                }
                else if (keyData == (Keys.Control | Keys.R))
                {
                    FileInfo fi = new FileInfo(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()));
                    _dataTable.Remove(fi.Name.ToLower());
                    WorkerArg arg = new WorkerArg(WorkerTypeEnum.LOAD_RES, fi.FullName);
                    if (bgWorker.IsBusy)
                    {
                        this.CreateWorkerInstance();
                    }
                    bgWorker.RunWorkerAsync(arg);
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void TranslateCell()
        {
            if (this.gridControl1.DataSource == null || lbRes == null || lbRes.DataSource == null || this._dataTable[lbRes.SelectedItem.ToString().ToLower()] == null)
            {
                XtraMessageBox.Show("Data not found");
                return;
            }
            GridView view = (GridView)gridControl1.FocusedView;
            string selectedValue = view.FocusedValue.ToString();
            view.SetFocusedValue(Translator.translate(selectedValue));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void gridView1_CellValueChanging(object sender, CellValueChangedEventArgs e)
        {
            if (gridView1.GetSelectedCells().Length > 0)
            {
                foreach (GridCell cell in gridView1.GetSelectedCells())
                {
                    if (cell.RowHandle == e.RowHandle && cell.Column == e.Column)
                    {
                        continue;
                    }
                    gridView1.SetRowCellValue(cell.RowHandle, cell.Column, e.Value);
                }
            }
        }
    }
}
