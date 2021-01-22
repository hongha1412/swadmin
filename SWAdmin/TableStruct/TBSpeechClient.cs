using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBSpeechClient : BaseStruct
    {
        public TBSpeech[] lsData;
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

        public class TBSpeech : BaseStruct
        {
            public UInt32 Unknown1;
            public Byte Unknown2;
            public Byte Unknown3;
            public Byte Unknown4;
            public UInt32 Unknown5;
            public UInt32 Unknown6;
            public UInt32 Unknown7;
            public String Unknown8 = "";
            public Byte Unknown9;
            public Byte Unknown10;
            public Byte Unknown11;
            public UInt32 Unknown12;
            public UInt32 Unknown13;
            public UInt32 Unknown14;
            public String Unknown15 = "";

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
