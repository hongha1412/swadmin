using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBNPCServer : BaseStruct
    {
        public NPCInfo[] lsData;
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

        public class NPCInfo : BaseStruct
        {
            public UInt32 NPC_ID;
            public UInt16 Npc_Group_ID;
            public Byte NPC_Faction;
            public String NPC_Code_Name = "";
            public Byte NPC_Status_Type;
            public UInt32 NPC_Status_ID;
            public Byte NPC_Level;
            public UInt32 NPC_Sight;
            public UInt16 NPC_Walk_Speed;
            public UInt16 NPC_Run_Speed;
            public UInt16 NPC_Turn_Speed;
            public Byte NPC_League;
            public Byte NPC_Intersperse_Type;
            public Byte NPC_Function_Type_01;
            public Byte NPC_Function_Type_02;
            public Byte NPC_Function_Type_03;
            public UInt16 NPC_Function_ID_01;
            public UInt16 NPC_Function_ID_02;
            public UInt16 NPC_Function_ID_03;
            public UInt32 Def_Talk_ID;
            public UInt32 NPC_TalkList_ID;
            public UInt16 NPC_CollisionRadius;
            public UInt16 NPC_CollisionHeight;
            public UInt16 NPC_RealHeight;

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
