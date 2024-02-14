using System;

namespace Lab3App
{
     public class Diamond : Treasure
    {
        //Diamond constructor
        public Diamond(string description, int score) : base(description, score) { }
        
        //Display method
        public override void Display()
        {
            Console.WriteLine("Diamond " + Description + " is displayed");
        }
    }
}