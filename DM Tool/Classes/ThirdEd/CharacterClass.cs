using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class CharacterClass
    {
        public CharacterClass()
        {
        }

        public CharacterClass(string n, int bab, string hdSize, int fort, int reflex, int will, string skills)
        {
            this._name = n;
            this._baseAttackBonus = bab;
            this._hitDieSize = Convert.ToInt32(hdSize);
            this._fortSave = fort;
            this._refSave = reflex;
            this._willSave = will;
            this._skillPoints = Convert.ToInt32(skills);
        }

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _hitDieSize;
        public int hitDieSize
        {
            get { return _hitDieSize; }
            set { _hitDieSize = value; }
        }

        private int _baseAttackBonus;
        public int baseAttackBonus
        {
            get { return _baseAttackBonus; }
            set { _baseAttackBonus = value; }
        }

        private int _fortSave;
        public int fortSave
        {
            get { return _fortSave; }
            set { _fortSave = value; }
        }

        private int _refSave;
        public int refSave
        {
            get { return _refSave; }
            set { _refSave = value; }
        }

        private int _willSave;
        public int willSave
        {
            get { return _willSave; }
            set { _willSave = value; }
        }

        private int _skillPoints;
        public int skillPoints
        {
            get { return _skillPoints; }
            set { _skillPoints = value; }
        }
    }
}
