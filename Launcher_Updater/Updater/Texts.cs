using System.Collections.Generic;

namespace Launcher
{
    class Texts
    {
        public enum Keys
        {
            UNKNOWNERROR,
            MISSINGBINARY,
            CANNOTSTART,
            NONETWORK,
            CONNECTING,
            LISTDOWNLOAD,
            CHECKFILE,
            DOWNLOADFILE,
            COMPLETEPROGRESS,
            CURRENTPROGRESS,
            CHECKCOMPLETE,
            DOWNLOADCOMPLETE,
            DOWNLOADSPEED
        }

        private static Dictionary<Keys, string> Text = new Dictionary<Keys, string>
        {
            {Keys.UNKNOWNERROR,                         "Erro critico: \n{0}"},
            {Keys.MISSINGBINARY,                        "O jogo nao pode ser iniciado porque está faltando {0} ."},
            {Keys.CANNOTSTART,                          "O jogo nao pode ser iniciado porque {0} não pode ser acessado."},
            {Keys.NONETWORK,                            "Impossivel conectar ao servidor de dados."},
            {Keys.CONNECTING,                           "Conectando ao servidor de dados..."},
            {Keys.LISTDOWNLOAD,                         "Baixando lista de atualizações..."},
            {Keys.CHECKFILE,                            "{0} Verificando..."},
            {Keys.DOWNLOADFILE,                         "{0} Baixando... {1}/ {2}"},
            {Keys.COMPLETEPROGRESS,                     "Progresso total: {0}%"},
            {Keys.CURRENTPROGRESS,                      "Progresso parcial: {0}%  |  {1} kb/s"},
            {Keys.CHECKCOMPLETE,                        "Cliente já está atualizado."},
            {Keys.DOWNLOADCOMPLETE,                     "Cliente atualizado com sucesso."},
            {Keys.DOWNLOADSPEED,                        "{0} kb/s"}
        };

        public static string GetText(Keys Key, params object[] Arguments)
        {
            foreach (KeyValuePair<Keys, string> currentItem in Text)
            {
                if (currentItem.Key == Key)
                {
                    return string.Format(currentItem.Value, Arguments);
                }
            }

            return null;
        }
    }
}
