using System;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description): base(description){
        }

        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used.");
        }
    }
}