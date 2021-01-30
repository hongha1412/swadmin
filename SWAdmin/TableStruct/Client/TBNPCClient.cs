using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWAdmin.TableStruct
{
    public class TBNPCClient : BaseStruct
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
            public UInt32 Unknown1;
            public UInt32 Unknown2;
            public UInt32 Unknown3;
            public UInt32 Unknown4;
            public UInt32 Unknown5;
            public Byte NPC_Status_Type;
            public UInt32 NPC_Status_ID;
            public Byte NPC_Level;
            public Byte Unknown6;
            public UInt32 Unknown7;
            public Byte Unknown8;
            public UInt32 Unknown9;
            public Byte Unknown10;
            public UInt32 NPC_Sight;
            public UInt16 NPC_Walk_Speed;
            public UInt16 NPC_Run_Speed;
            public UInt16 NPC_Turn_Speed;
            public Byte NPC_League;
            public Byte NPC_Intersperse_Type;
            public Byte NPC_Function_Type_01;
            public Byte NPC_Function_Type_02;
            public Byte NPC_Function_Type_03;
            public Byte NPC_Function_Type_04;
            public UInt16 NPC_Function_ID_01;
            public UInt16 NPC_Function_ID_02;
            public UInt16 NPC_Function_ID_03;
            public UInt16 NPC_Function_ID_04;
            public UInt16 Unknown12;
            public Byte Unknown13;
            public UInt32 Def_Talk_ID;
            public UInt32 NPC_TalkList_ID;
            public String Unknown14 = "";
            public UInt32 Unknown15;
            public UInt32 Unknown16;
            public UInt32 Unknown17;
            public UInt32 Unknown18;
            public UInt32 Unknown19;
            public UInt32 Unknown20;
            public UInt16 Unknown21;
            public UInt16 NPC_CollisionRadius;
            public UInt16 NPC_CollisionHeight;
            public UInt16 NPC_RealHeight;
            public String Unknown22 = "";
            public String Unknown23 = "";
            public String Unknown24 = "";
            public String Unknown25 = "";
            public String Unknown26 = "";

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
