using System;

namespace SWAdmin.TableStruct
{
    public class TBWARLORDGUIServer : BaseStruct
    {
        public WARLORD_GUIInfo[] lsData;
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

        public class WARLORD_GUIInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Jump_Type;
            public UInt32 Jump_StartBox_ID;


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
