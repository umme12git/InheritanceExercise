using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Reptile : Animal
    {
        public Reptile()
        { 

        }

        public string TypeName { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        public void Crawl()
        {
            Console.WriteLine("The animal can crawl.");
        }



    }
}
