using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBSkillScriptClient : BaseStruct
    {
        public TBSkillScript[] lsData;
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

        public class TBSkillScript : BaseStruct
        {
            public UInt16 Unknown1;
            public String Unknown2 = "";
            public String Unknown3 = "";
            public String Unknown4 = "";
            public String Unknown5 = "";
            public UInt32 Unknown6;
            public UInt32 Unknown7;
            public String Unknown8 = "";
            public String Unknown9 = "";

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
