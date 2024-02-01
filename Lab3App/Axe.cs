using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Axe : Tool
    {
        
        public Axe(string name)
        {
            _name = name;
        }

        public override void doAction()
        {
            Console.WriteLine("Axe is Used");
        }

        public override void Display()
        {
            Console.WriteLine("Axe "+_name+" is displayed");
        }
        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(_name + " Collected, Congrats!!!");
            Console.WriteLine("Axe is Used");
        }
    }
}
