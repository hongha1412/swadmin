using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBReinforceServer : BaseStruct
    {
        public ReinforceInfo[] lsData;
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

        public class ReinforceInfo : BaseStruct
        {
            public UInt32 Reinforce_ID;
            public UInt16 Max_Reinforce;
            public UInt16 Basic_Try;
            public UInt16 Max_Try;
            public UInt32 Ether_R01;
            public UInt32 Ether_R02;
            public UInt32 Ether_R03;
            public UInt32 Ether_R04;
            public UInt32 Ether_R05;
            public UInt32 Ether_R06;
            public UInt32 Ether_R07;
            public UInt32 Ether_R08;
            public UInt32 Ether_R09;
            public UInt32 Ether_R10;
            public UInt32 Gold_R01;
            public UInt32 Gold_R02;
            public UInt32 Gold_R03;
            public UInt32 Gold_R04;
            public UInt32 Gold_R05;
            public UInt32 Gold_R06;
            public UInt32 Gold_R07;
            public UInt32 Gold_R08;
            public UInt32 Gold_R09;
            public UInt32 Gold_R10;
            public UInt32 BP_R01;
            public UInt32 BP_R02;
            public UInt32 BP_R03;
            public UInt32 BP_R04;
            public UInt32 BP_R05;
            public UInt32 BP_R06;
            public UInt32 BP_R07;
            public UInt32 BP_R08;
            public UInt32 BP_R09;
            public UInt32 BP_R10;
            public UInt32 Item01_R01;
            public UInt32 Item01_R02;
            public UInt32 Item01_R03;
            public UInt32 Item01_R04;
            public UInt32 Item01_R05;
            public UInt32 Item01_R06;
            public UInt32 Item01_R07;
            public UInt32 Item01_R08;
            public UInt32 Item01_R09;
            public UInt32 Item01_R10;
            public UInt16 Count01_R01;
            public UInt16 Count01_R02;
            public UInt16 Count01_R03;
            public UInt16 Count01_R04;
            public UInt16 Count01_R05;
            public UInt16 Count01_R06;
            public UInt16 Count01_R07;
            public UInt16 Count01_R08;
            public UInt16 Count01_R09;
            public UInt16 Count01_R10;
            public UInt32 Item02_R01;
            public UInt32 Item02_R02;
            public UInt32 Item02_R03;
            public UInt32 Item02_R04;
            public UInt32 Item02_R05;
            public UInt32 Item02_R06;
            public UInt32 Item02_R07;
            public UInt32 Item02_R08;
            public UInt32 Item02_R09;
            public UInt32 Item02_R10;
            public UInt16 Count02_R01;
            public UInt16 Count02_R02;
            public UInt16 Count02_R03;
            public UInt16 Count02_R04;
            public UInt16 Count02_R05;
            public UInt16 Count02_R06;
            public UInt16 Count02_R07;
            public UInt16 Count02_R08;
            public UInt16 Count02_R09;
            public UInt16 Count02_R10;
            public UInt16 Stay_R01;
            public UInt16 Stay_R02;
            public UInt16 Stay_R03;
            public UInt16 Stay_R04;
            public UInt16 Stay_R05;
            public UInt16 Stay_R06;
            public UInt16 Stay_R07;
            public UInt16 Stay_R08;
            public UInt16 Stay_R09;
            public UInt16 Stay_R10;
            public UInt16 Up_R01;
            public UInt16 Up_R02;
            public UInt16 Up_R03;
            public UInt16 Up_R04;
            public UInt16 Up_R05;
            public UInt16 Up_R06;
            public UInt16 Up_R07;
            public UInt16 Up_R08;
            public UInt16 Up_R09;
            public UInt16 Up_R10;
            public UInt16 Break_R01;
            public UInt16 Break_R02;
            public UInt16 Break_R03;
            public UInt16 Break_R04;
            public UInt16 Break_R05;
            public UInt16 Break_R06;
            public UInt16 Break_R07;
            public UInt16 Break_R08;
            public UInt16 Break_R09;
            public UInt16 Break_R10;
            public float Stat01_R01;
            public float Stat01_R02;
            public float Stat01_R03;
            public float Stat01_R04;
            public float Stat01_R05;
            public float Stat01_R06;
            public float Stat01_R07;
            public float Stat01_R08;
            public float Stat01_R09;
            public float Stat01_R10;

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
