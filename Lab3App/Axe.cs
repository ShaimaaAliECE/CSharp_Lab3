using System;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description) : base(description) { }
        public void Display()
        {
            Console.WriteLine("Axe " + this.description + " is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("Axe is used.")
        }
    }
}