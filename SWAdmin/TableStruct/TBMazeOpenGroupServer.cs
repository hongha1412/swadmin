using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBMazeOpenGroupServer : BaseStruct
    {
        public MazeOpenGroupInfo[] lsData;
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

        public class MazeOpenGroupInfo : BaseStruct
        {
            public UInt16 ID;
            public UInt16 OpenCondition_MazeID_01;
            public UInt16 OpenCondition_MazeID_02;
            public UInt16 OpenCondition_MazeID_03;
            public UInt16 OpenCondition_MazeID_04;
            public UInt16 OpenCondition_MazeID_05;
            public UInt16 OpenCondition_MazeID_06;
            public UInt16 OpenCondition_MazeID_07;
            public UInt16 OpenCondition_MazeID_08;
            public UInt16 OpenCondition_MazeID_09;
            public UInt16 OpenCondition_MazeID_10;

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
