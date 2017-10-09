using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day4IntrotoOOP
{
    class Barbarian
    {
        private string armorType;
        private string weaponType;
        private int numberOfTeeth;
        private int strideLength;
        private int health;
        private string name;

        public string Name
        {get { return this.name;}
        set {this.name = value;}
        }

        public int Health
        { get { return this.health; }
        set { this.health = value; }
        }

        public string ArmorType
        { get { return this.armorType; }
        set { this.armorType = value; }
        }

        public string WeaponType
        { get { return this.weaponType; }
        set { this.weaponType = value; }
        }

        public int NumberOfTeeth
        { get { return this.numberOfTeeth; }
        set { this.numberOfTeeth = value; }
        }
        public int StrideLength
        { get { return this.strideLength; }
        set { this.strideLength = value; }
        }

        //CONSTRUCTORS
        public Barbarian()
        {
        }

        public Barbarian(int numberOfTeeth, int strideLength, int health)
        {
            this.numberOfTeeth = numberOfTeeth;
            this.strideLength = strideLength;
            this.health = health;
        }

        public Barbarian(string weaponType, string armorType, int health)
        {
            this.weaponType = weaponType;
            this.armorType = armorType;
            this.health = health;
        }

        //METHODS
        public void Rage()
        {strideLength++;
            health = health + 5;
            Console.WriteLine();
        }

        public void SmooshingBaddies()
        { weaponType = "THE MORNINGSTAR";
            health = health + 2;
        }

        public void OutClassedByBaddies()
        { numberOfTeeth = numberOfTeeth - 2;
            health = health--;
        }

        
    }
}
