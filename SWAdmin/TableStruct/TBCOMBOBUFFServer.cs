using System;

namespace SWAdmin.TableStruct
{
    public class TBCOMBOBUFFServer : BaseStruct
    {
        public COMBO_BUFFInfo[] lsData;
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

        public class COMBO_BUFFInfo : BaseStruct
        {
            public UInt16 Combo_Index;
            public Byte SV_Absorb;
            public UInt16 Fixed_Buff_ID;
            public Byte Get_RBuff_Count;
            public UInt16 RBuff_ID_00;
            public UInt16 RBuff_ID_01;
            public UInt16 RBuff_ID_02;
            public UInt16 RBuff_ID_03;
            public UInt16 RBuff_ID_04;
            public UInt16 RBuff_ID_05;
            public UInt16 RBuff_ID_06;
            public UInt16 RBuff_ID_07;
            public UInt16 RBuff_Rate_00;
            public UInt16 RBuff_Rate_01;
            public UInt16 RBuff_Rate_02;
            public UInt16 RBuff_Rate_03;
            public UInt16 RBuff_Rate_04;
            public UInt16 RBuff_Rate_05;
            public UInt16 RBuff_Rate_06;
            public UInt16 RBuff_Rate_07;


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
