﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hacktoberfest
{
    // Inheritance
    class Cat : Pet
    {
        public Cat(string name, int age, string owner) : base(name, age, owner)
        {
        }

        public void DrinkMilk()
        {
            Console.WriteLine("Drinking milk...");
        }

        public override string MakeASound()
        {
            return "meow";
        }

        public override string ToString()
        {
            return string.Format("Cat\n{0}", base.ToString());
        }
    }
}
