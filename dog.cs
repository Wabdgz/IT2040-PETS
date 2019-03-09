using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Dog : Pet
    {
        public Dog(string name, string owner, double weight) : base("Dogs",name,owner,weight)
        {
        }

        public string Bark(int count)
        {
            string woof = null;
            int x;
            for (x = 1; x <= count; x++)
            {
                woof += "BARK!!!";
            }
            return woof;
        }
    }
}
