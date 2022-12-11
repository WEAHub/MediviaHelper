using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static MediviaHelper.Classes.Player;

namespace MediviaHelper.Classes
{
    public class Player
    {
        public string name { get; set; }
        public string server { get; set; }
        public double hp { get; set; }
        public double maxHP { get; set; }
        public double mana { get; set; }
        public double maxMana { get; set; }
        public bool online { get; set; }
        public double level { get; set; }
        public double levelPercent { get; set; }
        public double levelExp { get; set; }

        public bool hungry { get; set; }
        public bool battle { get; set; }

        public Player()
        {  

        }
    }
}
