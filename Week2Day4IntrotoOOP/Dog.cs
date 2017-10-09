using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4IntrotoOOP
{
    class Dog
    {
        //fields
        private string hairLength;
        private int dogHeight;
        private string runningSpeed;
        private double weight;

        //Properties
        public string FurLength
        {
            get { return this.hairLength; }
            set { this.hairLength = value; }
        }

        public int DogHeight
        { get { return this.dogHeight; }
            set { this.dogHeight = value; }
        }

        public string RunningSpeed
        { get {return this.runningSpeed;}
          set {this.runningSpeed = value;}
        }

        public double Weight
        { get { return this.weight; }
          set { this.weight = value; }
        }
        
        //behaviors
        //Constructors
          //default constructor
        public Dog()
        {

        }

        //overloaded constructor
        public Dog(string hairLength, int dogHeight)
        {
            this.hairLength = hairLength;
            this.dogHeight = dogHeight;
        }

        //Methods

        public void Run()
        {runningSpeed = "getting faster.";
            weight--;
        }

        public void Bark()
        { Console.WriteLine("\a");
        }

        public void Potty()
        { weight -= 0.1;
            //weight now equals -0.1 weight = weight -0.1
        }

        public void Groom()
        { hairLength = "all cleaned up.";
        }
    }
}
