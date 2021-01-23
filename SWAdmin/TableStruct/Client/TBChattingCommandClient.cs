using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBChattingCommandClient : BaseStruct
    {
        public TBChattingCommand[] lsData;
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

        public class TBChattingCommand : BaseStruct
        {
            public UInt32 Command_Index;
            public Byte Permission_Level;
            public String Command_1 = "";
            public String Command_2 = "";
            public String Command_3 = "";
            public String Command_4 = "";
            public String Command_5 = "";
            public UInt32 Act_Type;

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
