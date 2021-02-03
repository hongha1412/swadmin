using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBEchelonServer : BaseStruct
    {
        public EchelonInfo[] lsData;
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

        public class EchelonInfo : BaseStruct
        {
            public Byte Echelon_Index;
            public UInt16 Echelon_Name;
            public UInt16 Echelon_Tooltip;
            public String Echelon_Icon = "";
            public String BonusEff_Icon = "";
            public UInt32 Echelon_Exp;
            public UInt16 Echelon_Booster_ID;
            public Byte Echelon_Invalid;
            public UInt32 Echelon_Title;

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
