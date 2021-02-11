using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEDEFENCEServer : BaseStruct
    {
        public MODE_DEFENCEInfo[] lsData;
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

        public class MODE_DEFENCEInfo : BaseStruct
        {
            public Byte ID;
            public UInt32 Quest_ID;
            public UInt32 Maze_ID;
            public UInt32 Sector_ID;
            public UInt32 Def_Monster_ID;
            public UInt32 Def_Monster_AgrroValue;
            public UInt32 Def_Monster_AgrroInterval;
            public UInt16 Def_Monster_AgrroRange;
            public UInt32 Jump_StartBox_ID;
            public String Script_Name_String = "";
            public UInt16 SpawnBox_ID_01;
            public UInt16 SpawnBox_ID_02;
            public UInt16 SpawnBox_ID_03;
            public UInt16 SpawnBox_ID_04;
            public UInt16 SpawnBox_ID_05;
            public UInt16 SpawnBox_ID_06;
            public UInt16 SpawnBox_ID_07;
            public UInt16 SpawnBox_ID_08;
            public UInt16 SpawnBox_ID_09;
            public UInt16 SpawnBox_ID_10;


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
