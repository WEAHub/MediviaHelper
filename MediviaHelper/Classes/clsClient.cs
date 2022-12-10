using Memory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Net;

namespace MediviaHelper.Classes
{
    public class Client
    {

        [DllImport("user32.dll")]
        internal static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        [DllImport("user32.dll")]
        private static extern int SetForegroundWindow(IntPtr hwnd);

        public int processID { get; set; }
        public IntPtr mainWindow { get; set; }
        public Player player { get; set; }
        private readonly Mem MemLib = new Mem();
        public int PlayerFlags { get { return MemLib.ReadInt(PointersAddr.playerFlags); } }

        public enum Flags : int
        {
            Battle = 128,
            Hungry = 1024,
            ProtectionZone = 2048,
        }

        public Client(Process process)
        {
            processID = process.Id;
            mainWindow = process.MainWindowHandle;
            player = this.setPlayer();
            this.playerUpdate();
        }

       private Player setPlayer()
       {
            if(this.processID != 0)
            {
                MemLib.OpenProcess(this.processID);
                Player newPlayer = new Player();
                return newPlayer;
            }
            else
            {
                return null;
            }
        }
        public bool CheckFlag(Flags _flag)
        {
            uint flag = (uint)_flag;
            return ((PlayerFlags & flag) == flag);
        }

        public void playerUpdate()
        {
            this.player.name = MemLib.ReadString(PointersAddr.playerName); ;
            this.player.server = MemLib.ReadString(PointersAddr.playerServer);
            this.player.hp = MemLib.ReadDouble(PointersAddr.playerHP);
            this.player.maxHP = MemLib.ReadDouble(PointersAddr.playerMaxHP);
            this.player.mana = MemLib.ReadDouble(PointersAddr.playerMana);
            this.player.maxMana = MemLib.ReadDouble(PointersAddr.playerMaxMana);
            this.player.online = MemLib.ReadByte(PointersAddr.playerOnline) > 0;
            this.player.hungry = CheckFlag(Flags.Hungry);
            this.player.battle = CheckFlag(Flags.Battle);
        }

        public void FocusWindow()
        {
            ShowWindow(this.mainWindow, 3);
            SetForegroundWindow(this.mainWindow);
        }

    }

}
