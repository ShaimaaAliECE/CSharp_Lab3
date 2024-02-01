using System;
using System.Collections.Generic;
namespace Lab3App
{
    public class Coin : Treasure
    {
        public int value;
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public Coin (string description, int score, int value) : base(description, score)
        {
            this.value = value;
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