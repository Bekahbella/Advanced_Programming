using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    class Dog : Animal, IWorkable
    {
        public Dog(string name)
            : base(name)
        {
        }
        public override string Speak()
        {
            return "woof";
        }
        public string Work()
        {
            return "I watch the house";
        }
    }
}
