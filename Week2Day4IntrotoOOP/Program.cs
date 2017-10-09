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

            //Dog firstDoge = new Dog();
            //firstDoge.Weight = 60.00;
            //firstDoge.DogHeight = 3;
            //firstDoge.HairLength = "flowing mane";
            //firstDoge.RunningSpeed = "will fetch...maybe.";

            //firstDoge.Groom();
            //    Console.WriteLine(firstDoge.HairLength);

            //firstDoge.Run();
            //Console.WriteLine("The dog now weighs " +firstDoge.Weight);
            //Console.WriteLine(firstDoge.RunningSpeed);

            //firstDoge.Bark();

            //Dog secDoge = new Dog("fluffy", 21);
            //Console.WriteLine(secDoge.HairLength);

            //secDoge.Groom();
            //Console.WriteLine(secDoge.HairLength);

            //secDoge.RunningSpeed = "faster than the speed of light";
            //Console.WriteLine(secDoge.RunningSpeed);

            //secDoge.Run();
            //Console.WriteLine(secDoge.RunningSpeed);

            //secDoge.Weight = 78.1;
            //Console.WriteLine(secDoge.Weight);

            //secDoge.Potty();
            //Console.WriteLine(secDoge.Weight);

            //secDoge.Bark();

            Barbarian Hildegard = new Barbarian();
            Hildegard.StrideLength = 4;
            Hildegard.NumberOfTeeth = 32;
            Hildegard.Health = 116;
            Hildegard.ArmorType = "Drangonscale";
            Hildegard.WeaponType = "Two-Handed Greatsword";

            Console.WriteLine("Hildegard has a speed of " +Hildegard.StrideLength+ " and her weapon is " +Hildegard.WeaponType+ ".");

            Console.WriteLine(Hildegard.Rage);
        }
    }
}
