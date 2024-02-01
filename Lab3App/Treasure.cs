using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score;

        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }
        

        public void updateTotalScore()
        {
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }
    }
}