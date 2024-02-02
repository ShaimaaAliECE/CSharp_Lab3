using System;
using System.Collections.Generic;
namespace Lab3App
{
    public class Coin : Treasure
    {
        //Value attribute
        public int Value;

        //Coin constructor
        public Coin(string description, int score, int value): base (description, score)
        {
            Value = value;
        }

        //Display method
        public override void Display()
        {
            Console.WriteLine("Coin " + Description + " is displayed");
        }

        //updateTotalValue method
        public void updateTotalValue()
        {
            Board.TotalValue += Value;
            Console.WriteLine("Total Value is updated to: " + Board.TotalValue);
        }

        //AddMe method
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            updateTotalValue();
        }
    }
}