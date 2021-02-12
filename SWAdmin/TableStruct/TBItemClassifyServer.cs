using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBItemClassifyServer : BaseStruct
    {
        public ItemClassifyInfo[] lsData;
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

        public class ItemClassifyInfo : BaseStruct
        {
            public UInt32 Item_Classify_Index;
            public Byte GroupID;
            public Byte SubGroupID;
            public Byte CategoryID;
            public Byte SubCategoryID;
            public Byte Item_Gain_Type;
            public Byte Item_Inven_Type;
            public Byte Item_Slot_Type;
            public Byte Item_Repair_Type;
            public Byte Item_Use_State;
            public Byte Item_Use_Type;
            public Byte Consume_Type;
            public UInt16 Exchange_Apply_Fee;
            public UInt16 Classify_Align_Type;

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
