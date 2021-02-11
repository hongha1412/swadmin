using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDSTANDARDServer : BaseStruct
    {
        public MAZEREWARD_STANDARDInfo[] lsData;
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

        public class MAZEREWARD_STANDARDInfo : BaseStruct
        {
            public Int16 Episode_ID;
            public UInt16 Episode_Clear_Point;
            public Int16 Monster_Kill;
            public Int16 Kill_Success;
            public Int16 Kill_Fail;
            public Int16 Party_1;
            public Int16 Party_2;
            public Int16 Party_3;
            public Int16 Party_4;
            public Int32 Rank_C_Point;
            public Int32 Rank_B_Point;
            public Int32 Rank_A_Point;
            public Int32 Rank_S_Point;
            public Int32 Rank_SS_Point;


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
