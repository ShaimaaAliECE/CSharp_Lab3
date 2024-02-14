using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    abstract class Treasure : Collectable
    {
        private int score;

        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }

        public void UpdateTotalScore()
        {
            int tots = Board.TotalScore += score;

            Console.WriteLine($"Total Score is updated to: {tots}");
        }
        public override void AddMe(List<Collectable> collection)
        {
            base.AddMe(collection);
            UpdateTotalScore();
        }
        public override void Display(){}
    }
}