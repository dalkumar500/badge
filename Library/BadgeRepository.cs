using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class BadgeRepository
    {
        private readonly IDictionary<int, List<string>> dictionary = new Dictionary<int, List<string>>();

        public bool Add(Badge badge)
        {
            List<string> doors = badge.DoorNames;
            int key = badge.BadgeID;
            if (dictionary.ContainsKey(key))
            {
                return false;
            }
            else
            {
                dictionary.Add(key, doors);
                return true;
            }
        }

        public bool Remove(Badge Badge)
        {
            return dictionary.Remove(Badge.BadgeID);
        }

        public bool RemoveAllDoors(int id)
        {
            if (dictionary.ContainsKey(id))

            {
                List<string> doors = dictionary[id];
                doors.Clear();
                return true;
            }
            return false;



        }
        public List<string> ShowallList()
        {
            return (List<string>)dictionary.Values;
        }

        public bool UpdateMethod(int BadgeID, List<string> doorNames)
        {
            if (dictionary.ContainsKey(BadgeID))
            {
                dictionary[BadgeID] = doorNames;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
         


