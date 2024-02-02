using System;

namespace Lab3App
{
    public class Axe : Tool
    {
        //Axe constructor
        public Axe(string description): base(description){
        }

        //Display method
        public override void Display()
        {
            Console.WriteLine("Axe " + Description + " is displayed");
        }

        //DoAction method
        public override void DoAction()
        {
            Console.WriteLine("Axe is used.");
        }
    }
}