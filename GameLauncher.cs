using Microsoft.Xna.Framework;
using System;
using WiiPlayTanksRemake;
using LiteNetLib;
using LiteNetLib.Utils;

namespace WiiPlayTanksRemake
{
    public static class GameLauncher
    {
        public static bool AutoLaunch = true;
        public static bool IsRunning { get; private set; }
        public static void LaunchGame()
        {
            using var game = new TankGame();
            game.Run();
            IsRunning = true;
        }
        [STAThread]
        static void Main()
        {
            if (AutoLaunch)
                LaunchGame();
        }

        static void tst()
        {

        }
    }
}