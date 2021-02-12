using System;

namespace SWAdmin.TableStruct
{
    public class TBTRANSPORTINFOServer : BaseStruct
    {
        public TRANSPORT_INFOInfo[] lsData;
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

        public class TRANSPORT_INFOInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Transport_Type;
            public Byte Arrival_Type;
            public UInt16 Arrival_ID;
            public Byte Transport_Area_Type;
            public UInt32 Need_Gold;
            public Byte Check_Level;
            public UInt32 Check_Quest;
            public UInt32 Check_Achivement;
            public String Path_File_Name_String = "";
            public Byte Path_Direction_Type;
            public UInt32 Monster_ID;
            public Int16 Position_Box_ID;
            public Int16 Transport_Speed;


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
