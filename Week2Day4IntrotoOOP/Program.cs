using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4IntrotoOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cat mittens = new Cat();
            //mittens.Name = "Mittens";

            //Cat secondCat = new Cat("Oz", 3, "orange and white");

            //Console.WriteLine(mittens.Name);
            //Console.WriteLine(secondCat.Name);

            //mittens.Eat();
            //mittens.WorkOut();

            Dog firstDoge = new Dog();
            firstDoge.Weight = 60.00;
            firstDoge.DogHeight = 3;
            firstDoge.HairLength = "flowing mane";
            firstDoge.RunningSpeed = "will fetch...maybe.";

            firstDoge.Groom();
                Console.WriteLine(firstDoge.HairLength);

            firstDoge.Run();
            Console.WriteLine("The dog now weighs " +firstDoge.Weight);
            Console.WriteLine(firstDoge.RunningSpeed);

            firstDoge.Bark();



        }
    }
}
