using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TurningDemo
{
    class Page : ITurnable
    {
        public Page(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Turn()
        {
            return "I turn book pages";
        }
    }
     class Corner : ITurnable
        {
            public Corner(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
            public string Turn()
            {
                return "Turn the corner to get to where you are going";
            }
     }
      class Pancake : ITurnable
            {
                public Pancake(string name)
                {
                    Name = name;
                }
                public string Name { get; set; }
                public string Turn()
                {
                    return "Turn the pancake before it burns";
                }
      }
       class Leaf : ITurnable
                {
                    public Leaf(string name)
                    {
                        Name = name;
                    }
                    public string Name { get; set; }
                    public string Turn()
                    {
                        return "I turn colors in Autumn";
                    }

                }
            }

        

    
