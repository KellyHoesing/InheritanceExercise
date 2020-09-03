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
        public bool Flies { get; set; }
        public int AirSpeed { get; set; }
        public string BirdSound { get; set; }
        public bool Aquatic { get; set; }

    }
}
