using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pets
{
    class Cat : Pet
    {
        public Cat(string name, string owner, double weight) : base("Cats",name,owner,weight)
        {
        }
        public string Meow(int count)
        {
            int x;
            string rawr = null;
            for (x = 1; x <= count; x++)
            {
                rawr += "MEOW!!";
            }
            return rawr;
        }
    }
}
