using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_EX
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        //생성자
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;
        }
        private int numberOfScaryThings;
        public string ScaryThingIHave
        {
            get { return "I Have " + numberOfScaryThings + " spiders"; }
        }
        public void ScareLittleChildren()
        {
            Console.WriteLine("Boo! Gotcha!");
        }
    }
}
