using System;

namespace SWAdmin.TableStruct
{
    public class TBMYROOMFURNITUREServer : BaseStruct
    {
        public MYROOM_FURNITUREInfo[] lsData;
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

        public class MYROOM_FURNITUREInfo : BaseStruct
        {
            public UInt32 ID;
            public UInt32 Furniture_Item_Object_Type;
            public UInt32 Furniture_Item_ID;
            public UInt32 Furniture_Item_Dispose_Position;
            public UInt32 Furniture_Item_Greed_X_Coordinate;
            public UInt32 Furniture_Item_Greed_Y_Coordinate;
            public UInt32 Furniture_Item_Special_Use;
            public UInt32 Furniture_Item_Category;
            public String Make_Material_Icon_1_String = "";
            public UInt32 Make_Material_ID_1;
            public UInt32 Make_Material_Num_1;
            public String Make_Material_Icon_2_String = "";
            public UInt32 Make_Material_ID_2;
            public UInt32 Make_Material_Num_2;
            public String Make_Material_Icon_3_String = "";
            public UInt32 Make_Material_ID_3;
            public UInt32 Make_Material_Num_3;
            public UInt32 Furniture_Item_Make_Price;
            public UInt32 Furniture_Item_Special_Effect;
            public UInt32 Furniture_Item_Special_Effect_ID;


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
