using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DM_Tool.Classes;

namespace DM_Tool.Managers
{
    class DnDThirdEdManager : EditionObject
    {
        private static DnDThirdEdManager instance;

        public DnDThirdEdManager()
        {
            
        }

        public static DnDThirdEdManager GetInstance()
        {
            if (instance == null)
            {
                instance = new DnDThirdEdManager();
            }
            return instance;
        }

        public override List<String> GetBaseMenuItems()
        {
            return new List<string> { "Types", "Characters", "Character Classes", "Base Items", "Adventure Sites" };
        }

        public override void OpenSpecifiedWindow(string itemName)
        {
        }
    }
}
