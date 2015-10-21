using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Managers
{
    public class EditionObject
    {
        public virtual List<String> GetBaseMenuItems()
        {
            return new List<String>();
        }

        public virtual void OpenSpecifiedWindow(string itemName){
        }
    }
}
