using System;

namespace SWAdmin.TableStruct
{
    public class TBROOMRANKREWARDServer : BaseStruct
    {
        public ROOMRANK_REWARDInfo[] lsData;
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

        public class ROOMRANK_REWARDInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 Min_Ranking;
            public UInt16 Max_Ranking;
            public Byte Item_Amount_01;
            public Byte Item_Amount_02;


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
