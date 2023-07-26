using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicprograms1
{
    internal class Animal : Sound, AnimalType
    {
        private string name;
        private int tail, leg, mouth, eyes;
         
        public Animal(string name, int tail, int leg, int mouth, int eyes )
        {
            this.Name = name;
            this.Tail = tail;
            this.Leg = leg;
            this.Mouth = mouth;
            this.Eyes = eyes;
        }

        public string Name { get => name; set => name = value; }
        public int Tail { get => tail; set => tail = value; }
        public int Leg { get => leg; set => leg = value; }
        public int Mouth { get => mouth; set => mouth = value; }
        public int Eyes { get => eyes; set => eyes = value; }

        public void MakeSound(string name)
        {
            if (name == "Dog")
                Console.WriteLine("Bow Bow");
            else if (name == "cat")
                Console.WriteLine("Meow Meow");
            else
                Console.WriteLine("invalid");
        }
        public void Type( string name)
        {
            if (name == "Dog")
                Console.WriteLine("Carnivores");
            else if (name == "Cow")
                Console.WriteLine("Herbivores");
            else
                Console.WriteLine("invalid");
        }
    }
}
