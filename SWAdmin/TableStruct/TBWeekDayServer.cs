using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBWeekDayServer : BaseStruct
    {
        public WeekDayInfo[] lsData;
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

        public class WeekDayInfo : BaseStruct
        {
            public UInt16 daily_id;
            public Byte mission_group;
            public UInt16 mission_id_1;
            public UInt16 mission_id_2;
            public UInt16 mission_id_3;
            public UInt16 mission_id_4;
            public UInt16 mission_id_5;
            public UInt16 mission_id_6;
            public UInt16 mission_id_7;
            public UInt16 mission_id_8;
            public UInt16 mission_id_9;
            public UInt16 mission_id_10;
            public UInt16 mission_id_11;

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
