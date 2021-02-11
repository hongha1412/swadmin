using System;

namespace SWAdmin.TableStruct
{
    public class TBUNITYEVENTServer : BaseStruct
    {
        public UNITY_EVENTInfo[] lsData;
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

        public class UNITY_EVENTInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Grouton_Spawn_Ratio;
            public UInt16 SpawnGroup_Grouton;
            public UInt16 SpawnGroup_Stage_01;
            public UInt16 SpawnGroup_Stage_02;
            public UInt16 SpawnGroup_Stage_03;
            public UInt16 SpawnGroup_Stage_04;
            public UInt16 SpawnGroup_Stage_05;
            public UInt16 SpawnGroup_Stage_06;
            public UInt16 SpawnGroup_Stage_07;
            public UInt16 SpawnGroup_Stage_08;
            public UInt16 SpawnGroup_Stage_09;
            public UInt16 SpawnGroup_Stage_10;
            public UInt16 SpawnGroup_Stage_11;
            public UInt16 SpawnGroup_Stage_12;
            public UInt16 SpawnGroup_Stage_13;
            public UInt16 SpawnGroup_Stage_14;
            public UInt16 SpawnGroup_Stage_15;
            public UInt16 DS_Point_Stage_01;
            public UInt16 DS_Point_Stage_02;
            public UInt16 DS_Point_Stage_03;
            public UInt16 DS_Point_Stage_04;
            public UInt16 DS_Point_Stage_05;
            public UInt16 DS_Point_Stage_06;
            public UInt16 DS_Point_Stage_07;
            public UInt16 DS_Point_Stage_08;
            public UInt16 DS_Point_Stage_09;
            public UInt16 DS_Point_Stage_10;
            public UInt16 DS_Point_Stage_11;
            public UInt16 DS_Point_Stage_12;
            public UInt16 DS_Point_Stage_13;
            public UInt16 DS_Point_Stage_14;
            public UInt16 DS_Point_Stage_15;


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
