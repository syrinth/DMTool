using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes
{
    public class Room
    {
        public string _name;
        public string _description;
        public string _encounters;
        public string _loot;
        public string _traps;
        public string _relevantChecks;
        public string _rooms;

        public Room()
        {
        }

        public Room(string name)
        {
            this._name = name;
        }

        public int FillRoom(List<string> readItems, int startLoc)
        {
            this._name = readItems[startLoc++];
            this._description = readItems[startLoc++];
            this._encounters = readItems[startLoc++];
            this._loot = readItems[startLoc++];
            this._traps = readItems[startLoc++];
            this._relevantChecks = readItems[startLoc++];
            this._rooms = readItems[startLoc++];

            return startLoc;
        }
    }
}
