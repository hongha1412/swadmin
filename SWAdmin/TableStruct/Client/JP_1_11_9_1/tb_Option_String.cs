using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Auto Generated by GreenDamTan
//Not verified it work or not
namespace SWAdmin.TableStruct.Client.JP_1_11_9_1
{
    public class tb_Option_String_Client : BaseStruct
    {
        public tb_Option_String[] lsData;
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

        public class tb_Option_String : BaseStruct
        {
            public UInt16 Unkown1;
            public Byte Unkown2;
            public UInt16 Unkown3;
            public UInt16 Unkown4;
            public Byte Unkown5;
            public Byte Unkown6;


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
