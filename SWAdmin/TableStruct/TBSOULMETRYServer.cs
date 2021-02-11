using System;

namespace SWAdmin.TableStruct
{
    public class TBSOULMETRYServer : BaseStruct
    {
        public SOUL_METRYInfo[] lsData;
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

        public class SOUL_METRYInfo : BaseStruct
        {
            public UInt16 Soul_metry_ID;
            public UInt16 Soul_metry_complet_bit;
            public UInt16 Soul_metry_maze_object_1;
            public UInt16 Soul_metry_maze_object_2;
            public UInt16 Soul_metry_maze_object_3;
            public UInt16 Soul_metry_maze_object_4;
            public UInt16 Soul_metry_maze_object_5;
            public UInt16 Object_1_spawn_rate;
            public UInt16 Object_2_spawn_rate;
            public UInt16 Object_3_spawn_rate;
            public UInt16 Object_4_spawn_rate;
            public UInt16 Object_5_spawn_rate;
            public Byte Soul_metry_reward_item_type_1;
            public Byte Soul_metry_reward_item_type_2;
            public Byte Soul_metry_reward_item_1_count;
            public Byte Soul_metry_reward_item_2_count;


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
