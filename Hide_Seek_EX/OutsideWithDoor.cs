using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hide_Seek_EX
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription) : base(name, hot)
        {
            this.DoorDescription = doorDescription;
        }

        //읽기 전용 DoorDescription 속성
        public string DoorDescription { get; private set; }
        //DoorLocation 속성
        public Location DoorLocation { get; set; }
        
        public override string Description
        {
            get
            {
                return base.Description + "You see " + DoorDescription + ".";
            }
        }
    }
}
