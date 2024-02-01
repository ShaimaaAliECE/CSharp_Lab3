using System;
using System.Collections.Generic;
namespace Lab3App
{
    public class Coin : Treasure
    {
        public int Value;

        public Coin(string description, int score, int value)
        {
            Description = description;
            Score = score;
            Value = value;
        }

        public override void Display()
        {
            Console.WriteLine("Coin is displayed");
        }

        public void updateTotalValue()
        {
            Board.TotalValue = value;
            Console.WriteLine("Total value is updated to: " + Board.TotalValue);
        }

        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalScore();
        }
    }
}