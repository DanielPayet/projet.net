using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet.Net.model
{
    class Workspace
    {
        private static Workspace instance = null;
        private string chemin;
        private Workspace()
        {
        }

        public static Workspace getInstance()
        {
            if (instance == null)
            {
                return new Workspace();
            }
            else
            {
                return instance;
            }
        }
    }
}
