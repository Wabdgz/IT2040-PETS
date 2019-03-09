using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Pet
    {
        public string type;
        public string name;
        public string owner;
        public double weight;

        public Pet(string Type, string Name, string Owner, double Weight)
        {
            this.type = Type;
            this.name = Name;
            this.owner = Owner;
            this.weight = Weight;
        }

        public string getTag()
        {
            string returntag = "If lost get " + owner + " ASAP!";
            return returntag;
        }
    }
}
