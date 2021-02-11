using System;

namespace SWAdmin.TableStruct
{
    public class TBLEVELUPPOINTServer : BaseStruct
    {
        public LEVELUP_POINTInfo[] lsData;
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

        public class LEVELUP_POINTInfo : BaseStruct
        {
            public Byte ID;
            public Byte Level;
            public Int32 Need_EXP;
            public Byte Give_Skill_Point;
            public UInt16 SV_Max_Point;


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
