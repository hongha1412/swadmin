using System;

namespace SWAdmin.TableStruct
{
    public class TBREINFORCEOPTIONServer : BaseStruct
    {
        public REINFORCE_OPTIONInfo[] lsData;
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

        public class REINFORCE_OPTIONInfo : BaseStruct
        {
            public UInt32 Reinforce_Option_ID;
            public Byte Reinforce_Count;
            public Byte Phase_R01;
            public Byte Phase_R02;
            public Byte Phase_R03;
            public Byte Phase_R04;
            public Byte Phase_R05;
            public Byte OptionClass_R01;
            public Byte OptionClass_R02;
            public Byte OptionClass_R03;
            public Byte OptionClass_R04;
            public Byte OptionClass_R05;
            public UInt16 OptionID_R01;
            public UInt16 OptionID_R02;
            public UInt16 OptionID_R03;
            public UInt16 OptionID_R04;
            public UInt16 OptionID_R05;
            public UInt32 OptionValue_R01;
            public UInt32 OptionValue_R02;
            public UInt32 OptionValue_R03;
            public UInt32 OptionValue_R04;
            public UInt32 OptionValue_R05;


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
