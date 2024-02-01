using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class MagicWand : Tool
    {
        public MagicWand(String Name) { 
            this._name = Name;
        }
        public override void doAction()
        {
            Console.WriteLine("Magic Wand is Used");
        }

        public override void Display()
        {
           Console.WriteLine("MagicWand "+_name+" is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(_name + " Collected, Congrats!!!");
            Console.WriteLine("Magic Wand is used");
        }
    }
}
