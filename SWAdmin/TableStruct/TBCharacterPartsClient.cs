using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBCharacterPartsClient : BaseStruct
    {
        public TBCharacterParts[] lsData;
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

        public class TBCharacterParts : BaseStruct
        {
            public UInt16 Unknown1;
            public UInt16 Unknown2;
            public Byte Unknown3;
            public String Unknown4 = "";
            public String Unknown5 = "";
            public String Unknown6 = "";
            public String Unknown7 = "";
            public String Unknown8 = "";

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
