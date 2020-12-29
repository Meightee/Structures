using System;
using System.Collections.Generic;
using System.Text;

namespace Structures
{
    public class Child
    {
        string Name { get; set; }
        int Age { get; set; }
        string Verselet { get; set; }

        public Child (string name, int age, string verselet)
        {
            Name = name;
            Age = age;
            Verselet = verselet;
        }

        public void Info()
        {
            Console.WriteLine($" Это {Name}, ему(ей) {Age} лет, он(а) подготовил(а) стишок: {Verselet}");
        }
    }
}