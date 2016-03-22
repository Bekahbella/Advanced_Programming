using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RecoveringDemo
{
    class Patient : IRecoverable
    
    {
        static void Main(string[] args)
        {
            Patient bob = new Patient("Patient Bob");
            Upholsterer rich = new Upholsterer("Upholsterer Rich");
            FootballPlayer mike = new FootballPlayer("FootballPlayer Mike");
           

            Console.WriteLine(bob.Name + " says " + bob.Recover());
            Console.WriteLine(rich.Name + " says " + rich.Recover());
            Console.WriteLine(mike.Name + " says " + mike.Recover());

        }
    

        
        public Patient(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Recover()
        {
            return "I am getting better";
        }

        class Upholsterer : IRecoverable
        {
            public Upholsterer(string name)
            {
                Name = name;
            }
            public string Name { get; set; }
            public string Recover()
            {
                return "I recover couches";
            }
        }

            class FootballPlayer : IRecoverable
            {
                public FootballPlayer(string name)
                {
                    Name = name;
                }
                public string Name { get; set; }
                public string Recover()
                {
                    return "I recover fumbles";
                }
            }
        }
    }

    

