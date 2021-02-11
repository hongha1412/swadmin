using System;

namespace SWAdmin.TableStruct
{
    public class TBMAZEREWARDPARTYVALUEServer : BaseStruct
    {
        public MAZEREWARD_PARTYVALUEInfo[] lsData;
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

        public class MAZEREWARD_PARTYVALUEInfo : BaseStruct
        {
            public Byte ID;
            public Byte Number;
            public float EXP_Value_1;
            public float EXP_Value_2;
            public float EXP_Value_3;
            public float EXP_Value_4;
            public float Money_Value_1;
            public float Money_Value_2;
            public float Money_Value_3;
            public float Money_Value_4;


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
