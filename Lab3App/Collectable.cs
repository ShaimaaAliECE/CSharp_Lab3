using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string Description;
        public CollectionBoard Board;

        public abstract void Display();

        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
    }
}