using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4IntrotoOOP
{
    class Cat
    {
        //STATES
        //types of STATES
        //1. fields
        //private = access modifier; fields are private
        private string name;
        private int age;
        private string furColor;
        private bool isHungry = true;
           //all these are characteristics that belong to a CAT
           //within the fields, you CAN set values

        //2. Properties - usually public - kind of like a characteristic and kind of like a method - MOMMA BEAR - bouncer at the club - you gotta do it through me
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        //this is a method that allows us to create a Cat object where the stuff in parentheses is assigned to Cat
        public Cat(string name, int age, string furColor)
        {
            //this is an overloaded constructor - same name, different parameters, allows us to create a cat object where we assign the values right away
            //THIS IS A METHOD
            // right below here, this is the FIELD name - after the equals signs is the PARAMETERS name  
            // the word "this" is unneccesary  
            this.name = name;
            this.age = age;
            this.furColor = furColor;
        }

        //behaviors
        //constructors have METHODS
        public void Eat()
        {
            if (isHungry == true)
            { isHungry = false;
            }
            Console.WriteLine("Is the cat hungry? " +isHungry);

        }

        public void WorkOut()
        { if (isHungry == false)
            { isHungry = true;
            }
            Console.WriteLine("Is the cat hungry now? " +isHungry);
        }





            //BEHAVIORS


        //Constructors - allow us to create a new instance - instantiate 
        public Cat()
        {
            // default constructors have nothing in parentheses

        }






    }
}
