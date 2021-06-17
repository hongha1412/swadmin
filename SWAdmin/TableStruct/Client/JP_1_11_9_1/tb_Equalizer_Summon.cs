using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct.Client.JP_1_11_9_1
{
    public class tb_Equalizer_Summon_Client : BaseStruct
    {
        public tb_Equalizer_Summon[] lsData;
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

        public class tb_Equalizer_Summon : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;
            public UInt32 Unkown4;


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
