using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBDropGroupCharacterServer : BaseStruct
    {
        public DropGroupCharacterInfo[] lsData;
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

        public class DropGroupCharacterInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Item_Char_ID_01;
            public UInt32 Item_Char_ID_02;
            public UInt32 Item_Char_ID_03;
            public UInt32 Item_Char_ID_04;
            public UInt32 Item_Char_ID_05;
            public UInt32 Item_Char_ID_06;
            public UInt32 Item_Char_ID_07;
            public UInt32 Item_Char_ID_08;
            public UInt32 Item_Char_ID_09;
            public UInt32 Item_Char_ID_10;
            public Byte My_Item_Select_Value;

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
