using System;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        //MagicWand constructor
        public MagicWand(string description) : base(description) { }
        
        //Display method
        public override void Display()
        {
            Console.WriteLine("MagicWand " + Description + " is displayed");
        }
        
        //DoAction method
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used.");
        }
    }
}