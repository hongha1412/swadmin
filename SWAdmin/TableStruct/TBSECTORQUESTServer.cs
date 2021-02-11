using System;

namespace SWAdmin.TableStruct
{
    public class TBSECTORQUESTServer : BaseStruct
    {
        public SECTORQUESTInfo[] lsData;
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

        public class SECTORQUESTInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Before_Check_Quest_Type_01;
            public Byte Before_Check_Quest_Type_02;
            public Byte Before_Check_Quest_Type_03;
            public Byte Before_Check_Quest_State_01;
            public Byte Before_Check_Quest_State_02;
            public Byte Before_Check_Quest_State_03;
            public Byte Final_Check_Quest_Type_01;
            public Byte Final_Check_Quest_Type_02;
            public Byte Final_Check_Quest_Type_03;
            public Byte Final_Check_Quest_State_01;
            public Byte Final_Check_Quest_State_02;
            public Byte Final_Check_Quest_State_03;
            public UInt32 Final_Check_Quest_ID_01;
            public UInt32 Final_Check_Quest_ID_02;
            public UInt32 Final_Check_Quest_ID_03;


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
