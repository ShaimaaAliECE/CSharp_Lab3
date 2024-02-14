using System;
using System.Collections.Generic;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        //Score attribute
        public int Score;

        //Treasure constructor
        public Treasure(string description, int score) : base(description)
        {
            Score = score;
        }
        

        //updateTotalScore method 
        public void updateTotalScore()
        {
            //Increasing the total score attribute
            Board.TotalScore += Score;
            Console.WriteLine("Total Score is updated to: " + Board.TotalScore);
        }

        //AddMe method
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }
    }
}