using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBSpeechTagClient : BaseStruct
    {
        public TBSpeechTag[] lsData;
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

        public class TBSpeechTag : BaseStruct
        {
            public Byte Unknown1;
            public String Unknown2 = "";
            public Byte Unknown3;
            public UInt32 Unknown4;
            public UInt32 Unknown5;
            public UInt32 Unknown6;
            public UInt32 Unknown7;
            public UInt32 Unknown8;
            public UInt32 Unknown9;
            public UInt32 Unknown10;
            public UInt32 Unknown11;

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
