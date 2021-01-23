using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBQuestScriptClient : BaseStruct
    {
        public QuestScriptInfo[] lsData;
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

        public class QuestScriptInfo : BaseStruct
        {
            public UInt32 Quest_ID;
            public String Quest_Name = "";
            public String Quest_Description = "";
            public String Unknown1 = "";
            public String Unknown2 = "";
            public String Unknown3 = "";

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
