using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Inheritance
{
    abstract class Animal
    {
        private string name;
        public Animal(string name)
        {
            this.name = name;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }
        public abstract string Speak(); // abstract that will be overriden inside of derived class(es)     
    }

}
