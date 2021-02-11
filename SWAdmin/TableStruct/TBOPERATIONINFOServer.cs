using System;

namespace SWAdmin.TableStruct
{
    public class TBOPERATIONINFOServer : BaseStruct
    {
        public OPERATION_INFOInfo[] lsData;
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

        public class OPERATION_INFOInfo : BaseStruct
        {
            public UInt32 ID;
            public Byte Min_Member;
            public Byte Max_Member;
            public Int32 Matching_Progress_Time;
            public Int32 Matching_Confirm_Time;
            public Int32 Matching_Wating_Time;
            public Int32 HotTime_Start_1st;
            public Int32 HotTime_End_1st;
            public Int32 HotTime_Start_2nd;
            public Int32 HotTime_End_2nd;
            public Int32 HotTime_Start_3rd;
            public Int32 HotTime_End_3rd;
            public Int32 Reward_Attend;
            public Int32 User_Kill_Point;
            public UInt32 Ranking_Before_Reward;
            public UInt32 Ranking_Now_Reward;
            public Int32 Reward_01;
            public Int32 Reward_02;
            public Int32 Reward_03;
            public Int32 Reward_04;
            public Int32 Reward_05;
            public Int32 Reward_06;
            public Int32 Reward_07;
            public Int32 Reward_08;
            public Int32 Reward_Count_01;
            public Int32 Reward_Count_02;
            public Int32 Reward_Count_03;
            public Int32 Reward_Count_04;
            public Int32 Reward_Count_05;
            public Int32 Reward_Count_06;
            public Int32 Reward_Count_07;
            public Int32 Reward_Count_08;
            public Int32 Reward_Score_01;
            public Int32 Reward_Score_02;
            public Int32 Reward_Score_03;
            public Int32 Reward_Score_04;
            public Int32 Reward_Score_05;
            public Int32 Reward_Score_06;
            public Int32 Reward_Score_07;
            public Int32 Reward_Score_08;
            public UInt16 User_SectorID_1;
            public UInt16 User_SectorID_2;
            public UInt16 User_SectorID_3;
            public UInt16 User_SectorID_4;
            public UInt16 User_SectorID_5;
            public UInt16 User_SectorID_6;
            public UInt16 User_SectorID_7;
            public UInt16 User_SectorID_8;
            public Int32 User_Start_Point_1;
            public Int32 User_Start_Point_2;
            public Int32 User_Start_Point_3;
            public Int32 User_Start_Point_4;
            public Int32 User_Start_Point_5;
            public Int32 User_Start_Point_6;
            public Int32 User_Start_Point_7;
            public Int32 User_Start_Point_8;


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
