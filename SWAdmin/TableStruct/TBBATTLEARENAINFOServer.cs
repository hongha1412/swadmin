using System;

namespace SWAdmin.TableStruct
{
    public class TBBATTLEARENAINFOServer : BaseStruct
    {
        public BATTLE_ARENA_INFOInfo[] lsData;
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

        public class BATTLE_ARENA_INFOInfo : BaseStruct
        {
            public UInt16 ID;
            public Byte Contents_Type;
            public UInt32 Contents_ID;
            public UInt16 Maze_ID;


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
