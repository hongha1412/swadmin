using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Equalizer_Info_Client : BaseStruct
    {
        public tb_Equalizer_Info[] lsData;
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

        public class tb_Equalizer_Info : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt16 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;
            public String Unkown5 = "";
            public String Unkown6 = "";

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
