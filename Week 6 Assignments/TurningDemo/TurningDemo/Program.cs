using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace TurningDemo
{
    class Turning
    {
        static void Main()
        {
            Page book = new Page("Book");
            Console.WriteLine(book.Name + " says " + book.Turn());
            Corner street = new Corner("Jim");
            Console.WriteLine(street.Name + " says " + street.Turn());
            Pancake pan = new Pancake("Mom");
            Console.WriteLine(pan.Name + " says " + pan.Turn());
            Leaf tree = new Leaf("Tree");
            Console.WriteLine(tree.Name + " says " + tree.Turn());

        }
    }
}
