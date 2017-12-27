using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    public abstract class Pet
    {
        public string name;
        public int age;
        public string type;
        public bool isHungry;
        public bool breathesAir;

        public string Name
        { get; set; }

        public int Age
        { get; set; }

        public string Type
        { get; set; }

        public bool IsHungry
        { get; set; }

        public bool BreathesAir
        { get; set; }

        public Pet ()
        {

        }

        public Pet (string name, int age, string type)
        {
            this.name = name;
            this.age = age;
            this.type = type;
        }
    }
}
