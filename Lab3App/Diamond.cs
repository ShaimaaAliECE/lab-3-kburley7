using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Diamond : Treasure
    {
     
        public Diamond(string name, int score)
        {
            _name = name;
            _score = score;
        }



        public override void Display()
        {
            Console.WriteLine("Diamond" +_name + " is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(_name + " Collected, Congrats!!!");
            UpdateTotalScore();
        }
    }
}
