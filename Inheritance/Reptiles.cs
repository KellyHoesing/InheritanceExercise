using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Reptiles : Animal
    {
        public Reptiles()
        {

        }
        public bool Regenerates { get; set; }
        public bool ChangesColor { get; set; }
        public string ReptileSound { get; set; }
        public bool Venomous { get; set; }
    }
}
