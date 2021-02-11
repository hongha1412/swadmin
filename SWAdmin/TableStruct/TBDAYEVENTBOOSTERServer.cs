using System;

namespace SWAdmin.TableStruct
{
    public class TBDAYEVENTBOOSTERServer : BaseStruct
    {
        public DAY_EVENT_BOOSTERInfo[] lsData;
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

        public class DAY_EVENT_BOOSTERInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Booster_ID_01;
            public UInt16 Booster_ID_02;
            public UInt16 Booster_ID_03;
            public UInt16 Booster_ID_04;
            public UInt16 Booster_ID_05;
            public UInt16 Booster_ID_06;
            public UInt16 Booster_ID_07;
            public UInt16 Booster_ID_08;
            public UInt16 Booster_ID_09;
            public UInt16 Booster_ID_10;
            public UInt16 Booster_Rate_01;
            public UInt16 Booster_Rate_02;
            public UInt16 Booster_Rate_03;
            public UInt16 Booster_Rate_04;
            public UInt16 Booster_Rate_05;
            public UInt16 Booster_Rate_06;
            public UInt16 Booster_Rate_07;
            public UInt16 Booster_Rate_08;
            public UInt16 Booster_Rate_09;
            public UInt16 Booster_Rate_10;


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
