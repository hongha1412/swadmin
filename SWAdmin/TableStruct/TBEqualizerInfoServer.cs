using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBEqualizerInfoServer : BaseStruct
    {
        public TBEqualizerInfo[] lsData;
        public SWString md5_ = new SWString();

        public TBEqualizerInfoServer() { }

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

        public class TBEqualizerInfo : BaseStruct
        {
            public UInt32 Equalizer_ID;
          
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
