using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Seek_EX
{
    class Room : Location
    {
        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
        public string Decoration 
        { 
            get
            {
                return base.Description + "You see " + decoration + ".";
            }
         }
    }
}
