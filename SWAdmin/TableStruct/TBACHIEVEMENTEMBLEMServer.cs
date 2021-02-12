using System;

namespace SWAdmin.TableStruct
{
    public class TBACHIEVEMENTEMBLEMServer : BaseStruct
    {
        public ACHIEVEMENT_EMBLEMInfo[] lsData;
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

        public class ACHIEVEMENT_EMBLEMInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Achievement_Category;
            public UInt16 Achievement_Rate_1;
            public UInt16 Achievement_Rate_2;
            public UInt16 Achievement_Rate_Min_3;
            public UInt16 Achievement_Rate_Min_4;
            public UInt16 Achievement_Rate_Min_5;


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
