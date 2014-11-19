using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class CreatureSize
    {
        public string _name;
        public int _modifier;
        public int _specialMod;

        public CreatureSize()
        {
        }

        public CreatureSize(string name, int modifier, int specialMod)
        {
            _name = name;
            _modifier = modifier;
            _specialMod = specialMod;
        }

        public CreatureSize(List<string> readItems)
        {
            int i = 0;
            this._name = readItems[i++];
            this._modifier = Convert.ToInt32(readItems[i++]);
            this._specialMod = Convert.ToInt32(readItems[i++]);
        }

        public string GetName(){return _name;}
        public int GetModifier() { return _modifier; }
        public int GetSpecialModifier() { return _specialMod; }

    }
}
