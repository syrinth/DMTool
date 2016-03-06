using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DM_Tool.Classes;

namespace DM_Tool.Managers
{
    class PTU1_05Manager : EditionObject
    {
        private static PTU1_05Manager instance;

        public PTU1_05Manager()
        {
            
        }

        public static PTU1_05Manager GetInstance()
        {
            if (instance == null)
            {
                instance = new PTU1_05Manager();
            }
            return instance;
        }

        public override List<String> GetBaseMenuItems()
        {
            return new List<string> { "Items", "Pokedex", "Pokemon", "Trainers", "Adventure Sites", "Encounter Tables" };
        }
    }
}
