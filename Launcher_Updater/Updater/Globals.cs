using System.Collections.Generic;

namespace Launcher
{
    class Globals
    {
        public static string ServerURL      = "http://draconick.ddns.net/uplauncher/";
        public static string sitelauncher   = "http://draconick.ddns.net/launcher/";
        public static string webrequest     = "http://draconick.ddns.net/system/";
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "Game.exe";
        public static string directory      = "";
        public static string startparam     = "draconickbyfaelhs";
        public static string login          = "";
        public static string senha          = "";
        public static bool logado           = false;
        public static Main pForm;
        

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long FullSize;
        public static long CompleteSize;

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}
