using System.Collections.Generic;

namespace Launcher
{
    class Globals
    {
        public static string ServerURL      = "http://everymu.net/patch/";
        public static string sitelauncher   = "http://127.0.0.1/a.html";
        public static string webrequest     = "http://everymu.net/system/";
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "DraconicK.exe";
        public static string directory      = "Bin";
        public static string startparam     = "connect /u66.70.203.161 /p44405";
        public static string login          = "";
        public static string senha          = "";
        public static string donate         = "1";
        public static bool logado           = false;
        public static Main pForm;
        

        public static List<File>    Files    = new List<File>();
        public static List<string>  OldFiles = new List<string>();

        public static long FullSize;
        public static long CompleteSize;

        public static System.Diagnostics.Process jogo = new System.Diagnostics.Process();
        

        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
    }
}
