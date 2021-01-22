using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBSpecialMazeOpenServer : BaseStruct
    {
        public TBSpecialMazeOpen[] lsData;
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

        public class TBSpecialMazeOpen : BaseStruct
        {
            public UInt16 ID;
            public UInt16 OpenCondition_MazeGroupID_01;
            public UInt16 OpenCondition_MazeGroupID_02;
            public UInt16 OpenCondition_MazeGroupID_03;
            public UInt16 OpenCondition_MazeGroupID_04;
            public UInt16 OpenCondition_MazeGroupID_05;
            public UInt16 OpenCondition_MazeGroupID_06;
            public UInt16 OpenCondition_MazeGroupID_07;
            public UInt16 OpenCondition_MazeGroupID_08;
            public UInt16 OpenCondition_MazeGroupID_09;
            public UInt16 OpenCondition_MazeGroupID_10;

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
