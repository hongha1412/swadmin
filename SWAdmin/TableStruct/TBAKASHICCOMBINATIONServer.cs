using System;

namespace SWAdmin.TableStruct
{
    public class TBAKASHICCOMBINATIONServer : BaseStruct
    {
        public AKASHIC_COMBINATIONInfo[] lsData;
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

        public class AKASHIC_COMBINATIONInfo : BaseStruct
        {
            public Byte Combination_Rank;
            public UInt16 Combination_Need_Point;
            public UInt16 Combination_Success_Rate;
            public UInt32 Success_Group;
            public UInt32 Combination_Need_Zeny;


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
