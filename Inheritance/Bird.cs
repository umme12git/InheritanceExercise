using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird : Animal
    {
         public Bird()
         {

         }

        public string TypeName { get; set; }
        public  int Age { get; set; }
        public string Color { get; set; }
        public void Talks(string word)
        {
            Console.WriteLine($"The animal can talk {word}.");
        }
    }

}
