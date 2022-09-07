using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch1_DET_2022
{
    //internal abstract class Animal
    //{

    //        public int Age { get; set; }
    //        public string Name { get; set; }

    //        public string Gender { get; set; }

    //        public abstract string ToString();

    //    }
    public class Cat : Animal
    {
        public override string ToString()
        {
            return "meow-meow";
        }

        public class Dog : Animal
        {
            public override string ToString()
            {
                return "bow-bow";
            }
            class AnimalTest
            {
                public static void Main()
                {
                    List<Animal> Animals = new List<Animal>();
                    Animals.Add(new Dog());
                    Animals.Add(new Cat());

                    foreach (Animal a in Animals)
                        Console.WriteLine(a.ToString());

                }
            }
        }
    }
}


