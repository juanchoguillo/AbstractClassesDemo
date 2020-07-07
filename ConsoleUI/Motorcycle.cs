using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {

        }


        public override void DriveAbstract()
        {
            Console.WriteLine($"This is the abstract Motorcycle");
        }
    }
}
