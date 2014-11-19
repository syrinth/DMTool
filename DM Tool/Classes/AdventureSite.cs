using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DM_Tool.Classes 
{
    public class AdventureSite : DatabaseClass
    {
        public string _name;
        public List<string> _testing;
        public string _description;
        public string _location;
        public int _totalExp;
        public int _totalLoot;
        public int _panda;
        public List<Room> _rooms;
        

        public AdventureSite()
        {
            _rooms = new List<Room>();
        }

        public AdventureSite(string name, string desc, string loc, List<Room> rooms)
        {
            _name = name;
            _description = desc;
            _location = loc;
            _rooms = rooms;
        }

        public void AddRoom(Room r)
        {
            _rooms.Add(r);
        }

        public string GetName()
        {
            return _name;
        }

        public void SetName(string name)
        {
            this._name = name;
        }

        public string GetDescription()
        {
            return _description;
        }

        public string GetLocation()
        {
            return _location;
        }
        public Room FindRoom(string name)
        {
            foreach (Room r in _rooms)
            {
                if (r._name.Equals(name))
                {
                    return r;
                }
            }
            return null;
        }

        public List<Room> GetRooms()
        {
            return _rooms;
        }

        public List<string> GetRoomNames()
        {
            List<string> roomNames = new List<string>();
            foreach (Room r in _rooms)
            {
                roomNames.Add(r._name);
            }
            return roomNames;
        }

        public bool ContainsRoom(string name)
        {
            if (_rooms.Find(x => x._name.Equals(name)) != null)
            {
                return true;
            }
            return false;
        }
    }
}
