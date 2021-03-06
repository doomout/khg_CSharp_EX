using System;
using System.Collections.Generic;

namespace UpcastAnEntireList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>() {
                new Duck() { Kind = KindOfDuck.Mallard, Size = 17 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 18 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 14 },
                new Duck() { Kind = KindOfDuck.Muscovy, Size = 11 },
                new Duck() { Kind = KindOfDuck.Mallard, Size = 14 },
                new Duck() { Kind = KindOfDuck.Decoy, Size = 13 },
            };
            IEnumerable<Bird> upcastDucks = ducks;

            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size.ToString() + "-inch " + duck.Kind.ToString());
            }

            List<Object> birds = new List<Object>();
            birds.Add(new Bird() { Name = "Feathers" });
            birds.AddRange(ducks);
            birds.Add(new Penguin() { Name = "George" });
            birds.Add(new Shoe() { Color = "brown", Style = Style.Flipflops });
            foreach (Object bird in birds)
            {
                Console.WriteLine(bird);
            }

            Console.ReadKey();
        }
    }
}
