using System;
using System.Collections.Generic;
using System.Data;

namespace Lab3App
{
    internal abstract class Treasure : Collectable{
        public int _score;

        public void UpdateTotalScore()
        {
            Board.TotalScore += _score;
            Console.WriteLine("Total Score is updated to:"+Board.TotalScore);
        }
    }
}
