using System.Collections.Generic;

namespace Launcher
{
    class Globals
    {
#if DEBUG || RELEASE
        public static string ServerURL      = "http://muonline.pgbrasil.net/uplauncher/";
        public static string sitelauncher   = "http://muonline.pgbrasil.net/launcher/";
        public static string webrequest     = "http://muonline.pgbrasil.net/system/";
        public static string startparam = "PGBrasilMuOnline";
#endif
#if RAG_DEBUG_ || RAG_RELEASE_
        public static string ServerURL      = "http://ragnarok.pgbrasil.net/uplauncher/";
        public static string sitelauncher   = "http://ragnarok.pgbrasil.net/launcher/";
        public static string webrequest     = "http://ragnarok.pgbrasil.net/system/";
        public static string startparam     = "PGBrasilRagnarok";
#endif
#if MINE_DEBUG_ || MINE_RELEASE_
        public static string ServerURL      = "http://minecraft.pgbrasil.net/uplauncher/";
        public static string sitelauncher   = "http://minecraft.pgbrasil.net/launcher/";
        public static string webrequest     = "http://minecraft.pgbrasil.net/system/";
        public static string startparam     = "PGBrasilMinecraft";
#endif
        public static string PatchlistName  = "patchlist.txt";
        public static string BinaryName     = "Game.exe";
        public static string directory      = "";
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
