using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;

namespace Launcher
{
    class Globals
    {

#if DEBUG || RELEASE
        public static IPAddress x = Dns.GetHostAddresses("muonline.pgbrasil.net")[0];
        public static string hostip = x.ToString();
        public static string ServerURL = "http://" + hostip + "/patch/";
        public static string sitelauncher = "http://" + hostip + "/launcher/";
        public static string webrequest = "http://" + hostip + "/system/";
        public static string PatchlistName = "patchlist.txt";
        public static int loginport = 44444;
        public static int gsport = 55300;
        public static string BinaryName     = "MuOnline.exe";
        public static string directory      = "Bin";
        public static string startparam     = "connect /u"+hostip+" /p"+loginport;
#endif
#if RAG_DEBUG_ || RAG_RELEASE_
        public static IPAddress x = Dns.GetHostAddresses("ragnarok.pgbrasil.net")[0];
        public static string hostip = x.ToString();
        public static string ServerURL = "http://" + hostip + "/patch/";
        public static string sitelauncher = "http://" + hostip + "/launcher/";
        public static string webrequest = "http://" + hostip + "/system/";
        public static string PatchlistName = "patchlist.txt";
        public static int loginport = 6900;
        public static int charport = 6121;
        public static int mapport = 5121;
        public static string BinaryName = "Ragnarok.exe";
        public static string directory      = "";
        public static string startparam     = "a a a /chkBWTeam";
#endif
#if MINE_DEBUG_ || MINE_RELEASE_
        public static IPAddress x = Dns.GetHostAddresses("muonline.pgbrasil.net")[0];
        public static string hostip = x.ToString();
        public static string ServerURL = "http://" + hostip + "/patch/";
        public static string sitelauncher = "http://" + hostip + "/launcher/indexc.html";
        public static string webrequest = "http://" + hostip + "/system/";
        public static string PatchlistName = "patchlist.txt";
        public static int loginport = 25565;
        public static int gsport = 25565;
        public static string BinaryName = "minecraft.jar";
        public static string directory = "\\Java\\bin\\java.exe -jar ";
        public static string startparam = "";
#endif
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
        public static System.Diagnostics.Process setup = new System.Diagnostics.Process();


        public struct File
        {
            public string Name;
            public string Hash;
            public long   Size;
        }
        public static string Icon()
        {
            var outPutDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().CodeBase);
            var iconPath = Path.Combine(outPutDirectory, "ico.ico");
            string icon_path = new Uri(iconPath).LocalPath;
            return icon_path;
        }
    }
}
