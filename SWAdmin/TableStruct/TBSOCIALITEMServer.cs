using System;

namespace SWAdmin.TableStruct
{
    public class TBSOCIALITEMServer : BaseStruct
    {
        public SOCIAL_ITEMInfo[] lsData;
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

        public class SOCIAL_ITEMInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt32 Collision_Range;
            public UInt32 Use_Range;
            public UInt32 Offset_Dis;
            public Byte Use_Max;
            public UInt32 Duration_Time;
            public UInt16 Aura_ID;
            public String Social_Code_Name_String = "";
            public UInt32 Furniture_Object_ID;
            public Byte Social_Item_Type;


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
