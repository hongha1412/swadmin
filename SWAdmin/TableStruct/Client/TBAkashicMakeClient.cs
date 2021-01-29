using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBAkashicMakeClient : BaseStruct
    {
        public AkashicMakeInfo[] lsData;
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

        public class AkashicMakeInfo : BaseStruct
        {
            public UInt32 Akashic_Make_Index;
            public Byte Unknown1;
            public UInt32 Unknown2;
            public UInt32 Unknown3;
            public Byte Unknown4;
            public UInt32 Unknown5;
            public UInt32 Create_Akashic;
            public UInt32 Random_Need_Meterial;
            public UInt32 Random_Need_Gold;
            public UInt32 Akashic_Group;
            public UInt32 HiUInt32en_Need_Gold;
            public UInt32 HiUInt32en_Need_Item;
            public UInt32 Create_HiUInt32en;

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
