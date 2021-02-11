using System;

namespace SWAdmin.TableStruct
{
    public class TBQUESTCONDITIONServer : BaseStruct
    {
        public QUEST_CONDITIONInfo[] lsData;
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

        public class QUEST_CONDITIONInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Condition;
            public UInt32 High_Condition_ID;
            public UInt32 Link_Condition_ID;
            public Byte CutScene_Portal_control;
            public Byte Target_Type;
            public UInt32 Target_ID;
            public UInt32 Field_ID;
            public UInt32 Maze_group_ID;
            public Byte Group_Counting;
            public Byte Counter_Value;
            public UInt32 Fail_Death_ID;
            public UInt32 Fail_Range_ID;
            public UInt32 Fail_Range;
            public String Quest_Script_String = "";
            public Byte Add_item_condition_Count_01;
            public Byte Add_item_condition_Count_02;
            public Byte Remove_item_condition_Count_01;
            public Byte Remove_item_condition_Count_02;


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
