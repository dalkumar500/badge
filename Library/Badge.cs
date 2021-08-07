using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorNames { get; set; }

        public string Anameforthebadge { get; set; }

        

        public Badge() { }

        public Badge(int badgeid, List<string> doornames, string anameforthebadge)
        {
            BadgeID = badgeid;
            DoorNames = doornames;
            Anameforthebadge = anameforthebadge;




        }

        }
    }
