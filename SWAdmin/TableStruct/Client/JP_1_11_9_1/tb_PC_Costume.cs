using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Auto Generated by GreenDamTan
//Not verified it work or not
namespace SWAdmin.TableStruct.Client.JP_1_11_9_1
{
    public class tb_PC_Costume_Client : BaseStruct
    {
        public tb_PC_Costume[] lsData;
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

        public class tb_PC_Costume : BaseStruct
        {
            public UInt32 Unkown1;
            public UInt32 Unkown2;
            public UInt32 Unkown3;


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
