using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediviaHelper
{
    internal static class PointersAddr
    {
        private const string localEntityAddr = "base+0x00DB80A8";
        public static string playerName = $"{localEntityAddr},0x1D8";
        public static string playerServer = $"{localEntityAddr},0x1F8";
        public static string playerOnline = $"{localEntityAddr},0x178";

        public static string playerMana = $"{localEntityAddr},0x280,0x568";
        public static string playerMaxMana = $"{localEntityAddr},0x280,0x570";

        public static string playerHP = $"{localEntityAddr},0x280,0x530";
        public static string playerMaxHP = $"{localEntityAddr},0x280,0x538";

        public static string playerFlags = $"{localEntityAddr},0x280,0x528";

        public static string playerLevel= $"{localEntityAddr},0x280,0x558";
        public static string playerLevelPercent = $"{localEntityAddr},0x280,0x560";
        public static string playerLevelExp = $"{localEntityAddr},0x280,0x550";


    }
}
