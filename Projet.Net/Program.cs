using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projet.Net.model;

namespace Projet.Net
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main() {
            String appName = "noNameApp";

            // Gives the path of the Documents folder on the computer
            String path = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + appName;
            // I guess we could create the folder if it's not there on loading the appWindow ?
            Directory.CreateDirectory(path);
            // Then create the non existing .json
            File.Create(path + "\\workspace.json" );

            Base.getInstance().loadWorkspace();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppWindow());

        }
    }
}
