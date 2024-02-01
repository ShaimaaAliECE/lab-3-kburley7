using System;
using System.Collections.Generic;

namespace Lab3App
{
    internal class Coin : Treasure
    {
 
        public int _value;
        public Coin(String n, int score, int value) 
        {
            _name = n;
            _score = score;
            _value = value;
        }
        public void UpdateTotoalValue()
        {
            Board.TotalValue += _value;
            Console.WriteLine("Total value is updates to: "+Board.TotalValue);
        }

        public override void Display()
        {
            Console.WriteLine("Coin "+_name+" is displayed");
        }

        public override void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(_name + " Collected, Congrats!!!");
            UpdateTotalScore();
            UpdateTotoalValue();
        }
    
    }
}