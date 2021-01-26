using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBDropServer : BaseStruct
    {
        public DropInfo[] lsData;
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

        public class DropInfo : BaseStruct
        {
            public UInt32 Drop_Index;
            public Byte Drop_Rate_Clear;
            public UInt16 Gold_Chance;
            public UInt16 Gold_Min;
            public UInt16 Gold_Max;
            public UInt16 Gold_Jp_Rate;
            public Byte Gold_Jp_Multi;
            public UInt16 SV_Chance;
            public UInt16 SV_Min;
            public UInt16 SV_Max;
            public UInt16 Et_Chance;
            public UInt16 Et_Min;
            public UInt16 Et_Max;
            public UInt16 Et_Unit;
            public UInt16 Et_Jp_Rate;
            public UInt16 Et_Jp_Multi;
            public UInt16 BP_Chance;
            public UInt16 BP_Max;
            public UInt16 BP_Min;
            public UInt16 G_Chance_01;
            public UInt16 G_Chance_02;
            public UInt16 G_Chance_03;
            public UInt16 G_Chance_04;
            public UInt16 G_Chance_05;
            public UInt16 G_Chance_06;
            public UInt16 G_Chance_07;
            public UInt16 G_Chance_08;
            public UInt16 G_Chance_09;
            public UInt16 G_Chance_10;
            public UInt16 G_Chance_11;
            public UInt16 G_Chance_12;
            public UInt16 G_Chance_13;
            public UInt16 G_Chance_14;
            public UInt16 G_Chance_15;
            public UInt16 G_Chance_16;
            public UInt16 G_Chance_17;
            public UInt16 G_Chance_18;
            public UInt16 G_Chance_19;
            public UInt16 G_Chance_20;
            public UInt16 G_Chance_21;
            public UInt32 Group_ID_01;
            public UInt32 Group_ID_02;
            public UInt32 Group_ID_03;
            public UInt32 Group_ID_04;
            public UInt32 Group_ID_05;
            public UInt32 Group_ID_06;
            public UInt32 Group_ID_07;
            public UInt32 Group_ID_08;
            public UInt32 Group_ID_09;
            public UInt32 Group_ID_10;
            public UInt32 Group_ID_11;
            public UInt32 Group_ID_12;
            public UInt32 Group_ID_13;
            public UInt32 Group_ID_14;
            public UInt32 Group_ID_15;
            public UInt32 Group_ID_16;
            public UInt32 Group_ID_17;
            public UInt32 Group_ID_18;
            public UInt32 Group_ID_19;
            public UInt32 Group_ID_20;
            public UInt32 Group_ID_21;
            public UInt16 C_Chance_01;
            public UInt16 C_Chance_02;
            public UInt16 C_Chance_03;
            public UInt16 C_Chance_04;
            public UInt16 C_Chance_05;
            public UInt16 C_Chance_06;
            public UInt16 C_Chance_07;
            public UInt16 C_Chance_08;
            public UInt16 C_Chance_09;
            public UInt16 C_Chance_10;
            public UInt32 C_Group_ID_01;
            public UInt32 C_Group_ID_02;
            public UInt32 C_Group_ID_03;
            public UInt32 C_Group_ID_04;
            public UInt32 C_Group_ID_05;
            public UInt32 C_Group_ID_06;
            public UInt32 C_Group_ID_07;
            public UInt32 C_Group_ID_08;
            public UInt32 C_Group_ID_09;
            public UInt32 C_Group_ID_10;
            public UInt32 Quest_ID_01;
            public UInt32 Quest_ID_02;
            public UInt16 Q_Chance_01;
            public UInt16 Q_Chance_02;
            public Byte Q_Item_Drop_Type_01;
            public Byte Q_Item_Drop_Type_02;
            public UInt32 Q_Item_ID_01;
            public UInt32 Q_Item_ID_02;
            public UInt16 Q_Item_Min_01;
            public UInt16 Q_Item_Min_02;
            public UInt16 Q_Item_Max_01;
            public UInt16 Q_Item_Max_02;

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
