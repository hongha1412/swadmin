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
        public DXPopupMenu _exportMenu;
        public Form1()
        {
            InitializeComponent();
            _dataTable = new Dictionary<string, DataTable>();
            tabFormControl1.SelectedPage = tabFormPage1;
            tabFormControl1.SelectedContainer = tabFormContentContainer1;
        }

        private void CreateGridMenu()
        {
            if (_exportMenu == null)
            {
                _exportMenu = new DXPopupMenu();
                _exportMenu.Caption = "Export data";
                DXMenuItem toCsv = new DXMenuItem("-> to CSV");
                DXMenuItem toTxtPlain = new DXMenuItem("-> to plain text");
                DXMenuItem toTxtTrans = new DXMenuItem("-> to text for HQTranslation");
                toCsv.Click += (o, args) =>
                {
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
                _exportMenu.Items.Add(toCsv);
                _exportMenu.Items.Add(toTxtPlain);
                _exportMenu.Items.Add(toTxtTrans);
            }
        }

        private void InitServerSupportedFiles()
        {
            _supportedFiles = new Dictionary<string, BaseStruct>();
            _supportedFiles.Add("tb_item.res", new TBItemServer());
            _supportedFiles.Add("tb_shop.res", new TBShopServer());
            _supportedFiles.Add("tb_cashshop.res", new TBCashShopServer());
            _supportedFiles.Add("tb_cashshop_tab.res", new TBCashShopTabServer());
            _supportedFiles.Add("tb_cashbilling_info.res", new TBCashBillingInfoServer());
            _supportedFiles.Add("tb_skill.res", new TBSKILLServer());
            _supportedFiles.Add("tb_item_classify.res", new TBItemClassifyServer());
            _supportedFiles.Add("tb_equalizer_info.res", new TBEqualizerInfoServer());
            _supportedFiles.Add("tb_achievement.res", new TBAchievementServer());
            _supportedFiles.Add("tb_character_info.res", new TBCharacterInfoServer());
            _supportedFiles.Add("tb_chattingcommand.res", new TBChattingCommandServer());
            _supportedFiles.Add("tb_serverinfo.res", new TBServerInfoServer());
            _supportedFiles.Add("tb_specialmaze_open.res", new TBSpecialMazeOpenServer());
            _supportedFiles.Add("tb_maze_opencontrol.res", new TBMazeOpenControlServer());
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
            _supportedFiles.Add("tb_character_parts.res", new TBCharacterPartsClient());
            _supportedFiles.Add("tb_appearance.res", new TBAppearanceClient());
            _supportedFiles.Add("tb_loading_img.res", new TBLoadingImgClient());
            _supportedFiles.Add("tb_mazereward_golddirect.res", new TBMazeRewardGoldDirectClient());
            _supportedFiles.Add("tb_namefilter.res", new TBNameFilterClient());
            _supportedFiles.Add(ToLow("tb_Speech.res"), new TBSpeechClient());
            _supportedFiles.Add(ToLow("tb_Speech_tag.res"), new TBSpeechTagClient());
        }
        string ToLow(string input) {
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
                this._exportMenu = null;
                this.LoadResDir(arg.WorkerType, arg.WorkerType == WorkerTypeEnum.LOAD_SERVER_RES ? txtServerRes.Text : txtClientRes.Text);
            } else if (arg.WorkerType == WorkerTypeEnum.LOAD_RES)
            {
                this.LoadResData(arg.ArgValue.ToString());
                this.CreateGridMenu();
                // Prevent export data to txt HQTrans for server
                if (this._currentWork == WorkerTypeEnum.LOAD_SERVER_RES && _exportMenu.Items.Count > 0)
                {
                    _exportMenu.Items.RemoveAt(_exportMenu.Items.Count - 1);
                }
            } else if (arg.WorkerType == WorkerTypeEnum.SAVE_RES)
            {
                this.SaveResData();
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
                } catch (Exception ex)
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
            this._exportMenu = null;
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
            FileInfo fi = new FileInfo(Path.Combine(_currentResPath, lbRes.SelectedItem.ToString()));
            if (!fi.Exists)
            {
                XtraMessageBox.Show("Res file not found");
                return;
            }
            WorkerArg arg = new WorkerArg(WorkerTypeEnum.LOAD_RES, fi.FullName);
            if (bgWorker.IsBusy)
            {
                this.CreateWorkerInstance();
            }
            bgWorker.RunWorkerAsync(arg);
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
            catch (Exception ignored)
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
                if (_exportMenu != null)
                {
                    e.Menu.Items.Add(_exportMenu);
                }
            }
        }
    }
}
