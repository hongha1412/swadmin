using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class tb_Defensive_Weapon_Client : BaseStruct
    {
        public tb_Defensive_Weapon[] lsData;
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

        public class tb_Defensive_Weapon : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public Int16 Unkown3;
            public Int16 Unkown4;
            public Int16 Unkown5;
            public Int16 Unkown6;
            public Int16 Unkown7;
            public Byte Unkown8;
            public String Unkown9 = "";

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
