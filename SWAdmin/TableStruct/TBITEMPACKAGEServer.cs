using System;

namespace SWAdmin.TableStruct
{
    public class TBITEMPACKAGEServer : BaseStruct
    {
        public ITEM_PACKAGEInfo[] lsData;
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

        public class ITEM_PACKAGEInfo : BaseStruct
        {
            public UInt32 Package_ID;
            public UInt32 P_Gold;
            public UInt32 P_BP;
            public UInt32 P_Ether;
            public UInt32 Item_01;
            public UInt32 Item_02;
            public UInt32 Item_03;
            public UInt32 Item_04;
            public UInt32 Item_05;
            public UInt32 Item_06;
            public UInt32 Item_07;
            public UInt32 Item_08;
            public UInt32 Item_09;
            public UInt32 Item_10;
            public UInt32 Item_11;
            public UInt32 Item_12;
            public UInt32 Item_13;
            public UInt32 Item_14;
            public UInt32 Item_15;
            public Byte Unpacking_Function_Type_01;
            public Byte Unpacking_Function_Type_02;
            public Byte Unpacking_Function_Type_03;
            public Byte Unpacking_Function_Type_04;
            public Byte Unpacking_Function_Type_05;
            public Byte Unpacking_Function_Type_06;
            public Byte Unpacking_Function_Type_07;
            public Byte Unpacking_Function_Type_08;
            public Byte Unpacking_Function_Type_09;
            public Byte Unpacking_Function_Type_10;
            public Byte Unpacking_Function_Type_11;
            public Byte Unpacking_Function_Type_12;
            public Byte Unpacking_Function_Type_13;
            public Byte Unpacking_Function_Type_14;
            public Byte Unpacking_Function_Type_15;
            public UInt32 Count_01;
            public UInt32 Count_02;
            public UInt32 Count_03;
            public UInt32 Count_04;
            public UInt32 Count_05;
            public UInt32 Count_06;
            public UInt32 Count_07;
            public UInt32 Count_08;
            public UInt32 Count_09;
            public UInt32 Count_10;
            public UInt32 Count_11;
            public UInt32 Count_12;
            public UInt32 Count_13;
            public UInt32 Count_14;
            public UInt32 Count_15;


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
