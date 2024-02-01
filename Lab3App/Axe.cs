using System;

namespace Lab3App
{
    public class Axe : Tool
    {
        public Axe(string description){
            Description = description;
        }

        public void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        public override void DoAction()
        {
            Console.WriteLine("Axe is used.")
        }
    }
}