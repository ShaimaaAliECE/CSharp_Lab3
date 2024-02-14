using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Tool : Collectable
    {
        //Constructor for Tool
        public Tool(string description) : base(description){}
        
        //Abstract method to be overriden
        public abstract void DoAction();

        //AddMe method
        public override void AddMe(List<Collectable> list)
        {
            base.AddMe(list);
            DoAction();
        }
    }
}