using SEQ.Sim;
using Stride.Core;

namespace SeqEx
{
    [DataContract("NeutralFaction")]
    public class NeutralFaction : IFactionProvder
    {
        public string Cvar()
        {
            return "neutral";
        }
    }

    [DataContract("PlayerFaction")]
    public class PlayerFaction : IFactionProvder
    {
        public string Cvar()
        {
            return "player";
        }
    }

    [DataContract("EnemyFaction")]
    public class EnemyFaction : IFactionProvder
    {
        public string Cvar()
        {
            return "enemy";
        }
    }
}
