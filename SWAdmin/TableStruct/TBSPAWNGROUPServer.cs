using System;

namespace SWAdmin.TableStruct
{
    public class TBSPAWNGROUPServer : BaseStruct
    {
        public SPAWN_GROUPInfo[] lsData;
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

        public class SPAWN_GROUPInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 SpawnGroup_01;
            public UInt16 SpawnGroup_02;
            public UInt16 SpawnGroup_03;
            public UInt16 SpawnGroup_04;
            public UInt16 SpawnGroup_05;
            public UInt16 SpawnGroup_06;
            public UInt16 SpawnGroup_07;
            public UInt16 SpawnGroup_08;
            public UInt16 SpawnGroup_09;
            public UInt16 SpawnGroup_10;


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
