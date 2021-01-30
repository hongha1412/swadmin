using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBDropGroupServer : BaseStruct
    {
        public DropGroupInfo[] lsData;
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

        public class DropGroupInfo : BaseStruct
        {
            public UInt32 Group_Index;
            public UInt16 I_Chance_01;
            public UInt16 I_Chance_02;
            public UInt16 I_Chance_03;
            public UInt16 I_Chance_04;
            public UInt16 I_Chance_05;
            public UInt16 I_Chance_06;
            public UInt16 I_Chance_07;
            public UInt16 I_Chance_08;
            public UInt16 I_Chance_09;
            public UInt16 I_Chance_10;
            public UInt32 Item_ID_01;
            public UInt32 Item_ID_02;
            public UInt32 Item_ID_03;
            public UInt32 Item_ID_04;
            public UInt32 Item_ID_05;
            public UInt32 Item_ID_06;
            public UInt32 Item_ID_07;
            public UInt32 Item_ID_08;
            public UInt32 Item_ID_09;
            public UInt32 Item_ID_10;
            public Byte Item_Min_Cnt_01;
            public Byte Item_Min_Cnt_02;
            public Byte Item_Min_Cnt_03;
            public Byte Item_Min_Cnt_04;
            public Byte Item_Min_Cnt_05;
            public Byte Item_Min_Cnt_06;
            public Byte Item_Min_Cnt_07;
            public Byte Item_Min_Cnt_08;
            public Byte Item_Min_Cnt_09;
            public Byte Item_Min_Cnt_10;
            public Byte Item_Max_Cnt_01;
            public Byte Item_Max_Cnt_02;
            public Byte Item_Max_Cnt_03;
            public Byte Item_Max_Cnt_04;
            public Byte Item_Max_Cnt_05;
            public Byte Item_Max_Cnt_06;
            public Byte Item_Max_Cnt_07;
            public Byte Item_Max_Cnt_08;
            public Byte Item_Max_Cnt_09;
            public Byte Item_Max_Cnt_10;

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
