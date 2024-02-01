using System;

namespace Lab3App
{
    public class MagicWand : Tool
    {
        public MagicWand(string description) : base(description) { }
        public void Display()
        {
            Console.WriteLine("MagicWand " + this.description + " is displayed");
        }
        public override void DoAction()
        {
            Console.WriteLine("MagicWand is used.")
        }
    }
}