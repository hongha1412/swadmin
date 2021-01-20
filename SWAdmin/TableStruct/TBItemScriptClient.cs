using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBItemScriptClient : BaseStruct
    {
        public ItemScriptInfo[] lsData;
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

        public class ItemScriptInfo : BaseStruct
        {
            public UInt32 Item_ID;
            public String Item_icon = "";
            public String Unknown1 = "";
            public String Unknown2 = "";
            public String Unknown3 = "";
            public String Unknown4 = "";
            public String Unknown5 = "";
            public Byte Unknown6;
            public Byte Unknown7;
            public Byte Unknown8;
            public Byte Unknown9;
            public Byte Unknown10;
            public String Name = "";
            public String Description = "";

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
