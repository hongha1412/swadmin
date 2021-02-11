using System;

namespace SWAdmin.TableStruct
{
    public class TBMILEAGEServer : BaseStruct
    {
        public MILEAGEInfo[] lsData;
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

        public class MILEAGEInfo : BaseStruct
        {
            public UInt32 Mileage_ID;
            public UInt16 Mileage_Point_01;
            public UInt16 Mileage_Point_02;
            public UInt16 Mileage_Point_03;


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
