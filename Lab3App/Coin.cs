using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    class Coin : Treasure
    {   private int value;

        public Coin(string description, int score, int value) : base(description, score)
        {
            this.value = value;
        }
        public int Value
        {
            get { return value; }
            set { this.value = value; }
        }
        public override void Display()
        {
            Console.WriteLine($"Coin {description} is displayed");
        }
        public void UpdateTotalValue()
        {
            int vall = Board.TotalValue += value;
            Console.WriteLine($"Total Value us updated to: {vall}");
        }
        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalValue();
        }
    }
}