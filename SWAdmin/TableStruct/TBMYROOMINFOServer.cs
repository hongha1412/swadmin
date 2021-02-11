using System;

namespace SWAdmin.TableStruct
{
    public class TBMYROOMINFOServer : BaseStruct
    {
        public MYROOM_INFOInfo[] lsData;
        public SWString md5_ = new SWString();

        public override void beforeRead()
        {
        }

        public override void beforeWrite()
        {
        }

        public override void read(SWReader reader)
        {
        }

        public override void write(SWWriter writer)
        {
        }

        public class MYROOM_INFOInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 My_Room_Field_ID;
            public UInt32 My_Room_Max_Access_Member;
            public UInt32 My_Room_Create_Lv;
            public UInt32 My_Room_Create_Gold;
            public UInt32 Nomal_WallPaper_Item;
            public UInt32 Nomal_Floor_Item;
            public UInt32 Nomal_TerraceDoor_Item;
            public UInt32 Nomal_Window_Item;
            public UInt32 Nomal_Door_Item;
            public UInt32 Nomal_Ceiling_Item;
            public UInt32 Nomal_Pollen_Index_01;
            public UInt32 Nomal_Pollen_Index_02;
            public UInt32 Nomal_Pollen_Index_03;
            public UInt32 Nomal_Pollen_Index_04;
            public UInt32 Nomal_Pollen_Index_05;
            public UInt32 Nomal_Pollen_Index_06;
            public UInt32 Nomal_Pollen_Index_07;
            public UInt32 Nomal_Pollen_Index_08;
            public UInt32 Nomal_Pollen_Index_09;
            public UInt32 Nomal_Pollen_Index_10;


            public override void beforeRead()
            {
            }

            public override void beforeWrite()
            {
            }

            public override void read(SWReader reader)
            {
            }

            public override void write(SWWriter writer)
            {
            }
        }
    }
}
