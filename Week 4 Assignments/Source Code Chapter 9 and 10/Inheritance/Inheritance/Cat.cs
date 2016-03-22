using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Cat : Animal,IWorkable
    {
        public Cat(string name)
            : base(name)
        {
        }
        public override string Speak()
        {
            return "meow";
        }
        public string Work()
        {
            return "I catch mice";
        }
    }
}
