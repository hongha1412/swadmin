using System;

namespace SWAdmin.TableStruct
{
    public class TBDYEServer : BaseStruct
    {
        public DYEInfo[] lsData;
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

        public class DYEInfo : BaseStruct
        {
            public UInt16 Dye_ID;
            public Byte Icon_Dye_Color_R;
            public Byte Icon_Dye_Color_G;
            public Byte Icon_Dye_Color_B;
            public Byte Hidden_Info;
            public String Color_Hex_String = "";


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
