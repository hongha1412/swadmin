using System;

namespace SWAdmin.TableStruct
{
    public class TBDISTRICTTRANSPORTServer : BaseStruct
    {
        public DISTRICT_TRANSPORTInfo[] lsData;
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

        public class DISTRICT_TRANSPORTInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 District_ID;
            public UInt16 Transport_Info_ID_01;
            public UInt16 Transport_Info_ID_02;
            public UInt16 Transport_Info_ID_03;
            public UInt16 Transport_Info_ID_04;
            public UInt16 Transport_Info_ID_05;
            public Byte End_ID_01;
            public Byte End_ID_02;
            public Byte End_ID_03;
            public Byte End_ID_04;
            public Byte End_ID_05;


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
