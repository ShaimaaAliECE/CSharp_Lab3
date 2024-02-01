using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score;

        public void updateTotalScore()
        {
            Board.TotalScore += score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }
    }
}