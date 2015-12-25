using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DM_Tool.Classes;
using System.Windows.Forms;
using DM_Tool.Controls;

namespace DM_Tool
{
    public class StatBlock : DatabaseClass
    {
        public StatBlock(){
        }

        public StatBlock(string[] vals)//string name, string raceName, string classes, string levels, string type, string size, string hdNum, string hdSize, string hp, string init, string initMisc, string speed, string bab, string fort, string reflex, string will, string str, string dex, string con, string intelligence, string wis, string cha, string natAC, string armorAC, string shieldAC, string defAC, string attack, string fullAttack, string space, string reach, string specialAttacks, string specialQualities, string feats, string maxHP, string totalAC, string touchAC, string ffAC)
        {
            int count = 0;
            this._name = vals[count++];
            this._raceName = vals[count++];

            this._classes = vals[count++];
            this._levels = vals[count++];
            this._type = vals[count++];
            this._size = vals[count++];
            this._hitDieNum = PublicCode.ConvertToIntSafely(vals[count++]);
            this._hp = PublicCode.ConvertToIntSafely(vals[count++]);
            this._init = PublicCode.ConvertToIntSafely(vals[count++]);
            this._initMisc = PublicCode.ConvertToIntSafely(vals[count++]);
            this._speed = vals[count++];
            this._baseAttackBonus = PublicCode.ConvertToIntSafely(vals[count++]);
            this._fortSave = PublicCode.ConvertToIntSafely(vals[count++]);
            this._refSave = PublicCode.ConvertToIntSafely(vals[count++]);
            this._willSave = PublicCode.ConvertToIntSafely(vals[count++]);

            this._str = PublicCode.ConvertToIntSafely(vals[count++]);
            this._dex = PublicCode.ConvertToIntSafely(vals[count++]);
            this._con = PublicCode.ConvertToIntSafely(vals[count++]);
            this._int = PublicCode.ConvertToIntSafely(vals[count++]);
            this._wis = PublicCode.ConvertToIntSafely(vals[count++]);
            this._cha = PublicCode.ConvertToIntSafely(vals[count++]);
            this._natAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._armorAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._shieldAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._defAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._attack = vals[count++];
            this._fullAttack = vals[count++];
            this._space = PublicCode.ConvertToIntSafely(vals[count++]);
            this._reach = PublicCode.ConvertToIntSafely(vals[count++]);
            this._specialAttacks = vals[count++];
            this._specialQualities = vals[count++];
            this._feats = vals[count++];

            this._maxHP = PublicCode.ConvertToIntSafely(vals[count++]);
            this._totalAC = PublicCode.ConvertToIntSafely(vals[count++]);

            this._touchAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._ffAC = PublicCode.ConvertToIntSafely(vals[count++]);
            this._grapple = PublicCode.ConvertToIntSafely(vals[count++]);
            this._hdInfo = vals[count++];
        }

        #region get and Set
        private string _name;
        public string name
        {
            get {
                if (_name == null)
                {
                    return " ";
                }
                else
                {
                    return _name;
                }
            }
            set { _name = value; }
        }

        private string _raceName;
        public string raceName
        {
            get
            {
                if (_raceName == null)
                {
                    return " ";
                }
                else
                {
                    return _raceName;
                }
            }
            set { _raceName = value; }
        }

        private string _classes;
        public string classes
        {
            get
            {
                if (_classes == null)
                {
                    return "";
                }
                else
                {
                    return _classes;
                }
            }
            set { _classes = value; }
        }

        private string _levels;
        public string levels
        {
            get
            {
                if (_levels == null)
                {
                    return "";
                }
                else
                {
                    return _levels;
                }
            }
            set { _levels = value; }
        }

        private string _type;
        public string creatureType
        {
            get
            {
                if (_type == null)
                {
                    return " ";
                }
                else
                {
                    return _type;
                }
            }
            set { _type = value; }
        }

        private int _hitDieNum;
        public int hitDieNum
        {
            get { return _hitDieNum; }
            set { _hitDieNum = value; }
        }

        private string _hdInfo;
        public string hdInfo
        {
            get { return _hdInfo; }
            set { _hdInfo = value; }
        }

        private int _hp;
        public int hp
        {
            get { return _hp; }
            set { _hp = value; }
        }

        private int _init;
        public int init
        {
            get { return _init; }
            set { _init = value; }
        }

        private int _initMisc;
        public int initMisc
        {
            get { return _initMisc; }
            set { _initMisc = value; }
        }

        private string _speed;
        public string speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        private int _baseAttackBonus;
        public int baseAttackBonus
        {
            get { return _baseAttackBonus; }
            set { _baseAttackBonus = value; }
        }

        private int _grapple;
        public int grapple
        {
            get { return _grapple; }
            set { _grapple = value; }
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

        private int _str;
        public int str
        {
            get { return _str; }
            set { _str = value; }
        }

        private int _dex;
        public int dex
        {
            get { return _dex; }
            set { _dex = value; }
        }

        private int _con;
        public int con
        {
            get { return _con; }
            set { _con = value; }
        }

        private int _int;
        public int intelligence
        {
            get { return _int; }
            set { _int = value; }
        }

        private int _wis;
        public int wis
        {
            get { return _wis; }
            set { _wis = value; }
        }

        private int _cha;
        public int cha
        {
            get { return _cha; }
            set { _cha = value; }
        }

        private string _description;
        public string description
        {
            get
            {
                if (_description == null)
                {
                    return " ";
                }
                else
                {
                    return _description;
                }
            }
            set { _description = value; }
        }

        private string _size;
        public string size
        {
            get
            {
                if (_size == null)
                {
                    return " ";
                }
                else
                {
                    return _size;
                }
            }
            set { _size = value; }
        }

        private int _natAC;
        public int natAC
        {
            get { return _natAC; }
            set { _natAC = value; }
        }

        private int _armorAC;
        public int armorAC
        {
            get { return _armorAC; }
            set { _armorAC = value; }
        }

        private int _shieldAC;
        public int shieldAC
        {
            get { return _shieldAC; }
            set { _shieldAC = value; }
        }

        private int _defAC;
        public int defAC
        {
            get { return _defAC; }
            set { _defAC = value; }
        }

        private string _attack;
        public string attack
        {
            get
            {
                if (_attack == null)
                {
                    return " ";
                }
                else
                {
                    return _attack;
                }
            }
            set { _attack = value; }
        }

        private string _fullAttack;
        public string fullAttack
        {
            get
            {
                if (_fullAttack == null)
                {
                    return " ";
                }
                else
                {
                    return _fullAttack;
                }
            }
            set { _fullAttack = value; }
        }

        private int _space;
        public int space
        {
            get { return _space; }
            set { _space = value; }
        }

        private int _reach;
        public int reach
        {
            get { return _reach; }
            set { _reach = value; }
        }

        private string _specialAttacks;
        public string specialAttacks
        {
            get
            {
                if (_specialAttacks == null)
                {
                    return " ";
                }
                else
                {
                    return _specialAttacks;
                }
            }
            set { _specialAttacks = value; }
        }

        private string _specialQualities;
        public string specialQualities
        {
            get
            {
                if (_specialQualities == null)
                {
                    return " ";
                }
                else
                {
                    return _specialQualities;
                }
            }
            set { _specialQualities = value; }
        }

        private string _feats;
        public string feats
        {
            get
            {
                if (_feats == null)
                {
                    return " ";
                }
                else
                {
                    return _feats;
                }
            }
            set { _feats = value; }
        }

        private int _maxHP;
        public int maxHP
        {
            get { return _maxHP; }
            set { _maxHP = value; }
        }

        private int _totalAC;
        public int totalAC
        {
            get { return _totalAC; }
            set { _totalAC = value; }
        }

        private int _touchAC;
        public int touchAC
        {
            get { return _touchAC; }
            set { _touchAC = value; }
        }

        private int _ffAC;
        public int ffAC
        {
            get { return _ffAC; }
            set { _ffAC = value; }
        }
        #endregion
    }
}
