using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct.Client.JP_1_11_9_1
{
    public class tb_Maze_Select_Client : BaseStruct
    {
        public tb_Maze_Select[] lsData;
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

        public class tb_Maze_Select : BaseStruct
        {
            public UInt16 Unkown1;
            public String Unkown2 = "";
            public String Unkown3 = "";
            public UInt16 Unkown4;
            public UInt16 Unkown5;
            public UInt16 Unkown6;
            public UInt16 Unkown7;
            public UInt16 Unkown8;
            public UInt16 Unkown9;
            public UInt16 Unkown10;
            public UInt16 Unkown11;
            public UInt16 Unkown12;
            public UInt16 Unkown13;
            public UInt16 Unkown14;
            public UInt16 Unkown15;
            public UInt16 Unkown16;
            public UInt16 Unkown17;
            public UInt16 Unkown18;


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
