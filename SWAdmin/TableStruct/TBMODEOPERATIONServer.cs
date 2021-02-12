using System;

namespace SWAdmin.TableStruct
{
    public class TBMODEOPERATIONServer : BaseStruct
    {
        public MODE_OPERATIONInfo[] lsData;
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

        public class MODE_OPERATIONInfo : BaseStruct
        {
            public Byte ID;
            public UInt32 Taget_Monster;
            public UInt16 OP_Mode_Maze_ID;
            public UInt16 OP_Mode_Sector;
            public UInt32 OP_Mode_Time;
            public UInt32 OP_Mode_Start_String;
            public UInt32 OP_Mode_Success_Taget;
            public UInt32 OP_Mode_Success_Buff;
            public UInt32 OP_Mode_Fail_Buff;
            public UInt32 Success_Message;
            public UInt32 Fail_Message;
            public Byte Start_Condition_1;
            public Byte Start_Condition_2;
            public Byte Start_Condition_3;
            public Byte Start_Condition_4;
            public Byte Start_Condition_5;
            public UInt16 OP_Mode_After_time_1;
            public UInt16 OP_Mode_After_time_2;
            public UInt16 OP_Mode_After_time_3;
            public UInt32 OP_Mode_After_time_String_1;
            public UInt32 OP_Mode_After_time_String_2;
            public UInt32 OP_Mode_After_time_String_3;
            public UInt32 OP_Mode_Object_1;
            public UInt32 OP_Mode_Object_2;
            public UInt32 OP_Mode_Object_3;
            public UInt32 OP_Mode_Object_4;
            public UInt32 OP_Mode_Object_5;


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
