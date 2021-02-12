using System;

namespace SWAdmin.TableStruct
{
    public class TBHIDDENEVENTServer : BaseStruct
    {
        public HIDDEN_EVENTInfo[] lsData;
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

        public class HIDDEN_EVENTInfo : BaseStruct
        {
            public UInt16 Hidden_Event_ID;
            public UInt32 Reward_Item;
            public Byte Reward_Count;
            public UInt32 Event_Condition_ID_01;
            public UInt32 Event_Condition_ID_02;
            public UInt32 Event_Condition_ID_03;
            public UInt32 Event_Condition_ID_04;
            public UInt32 Event_Condition_ID_05;
            public UInt16 Condition_Select_Rate_01;
            public UInt16 Condition_Select_Rate_02;
            public UInt16 Condition_Select_Rate_03;
            public UInt16 Condition_Select_Rate_04;
            public UInt16 Condition_Select_Rate_05;


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
