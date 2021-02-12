using System;

namespace SWAdmin.TableStruct
{
    public class TBBROACHCOMPOSETHEMEServer : BaseStruct
    {
        public BROACHCOMPOSE_THEMEInfo[] lsData;
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

        public class BROACHCOMPOSE_THEMEInfo : BaseStruct
        {
            public UInt16 Broach_Theme_Value;
            public UInt16 Result_Theme_01;
            public UInt16 Result_Theme_02;
            public UInt16 Result_Theme_03;
            public UInt16 Result_Theme_04;


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
