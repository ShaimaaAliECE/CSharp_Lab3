using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        //Description attribute 
        public string Description;

        //Public CollectionBoard
        public CollectionBoard Board;

        //Collectable constructor
        public Collectable(string description)
        {
            Description = description;
        }
        
        //Display abstract method from the Displayable interface
        public abstract void Display();

        //AddMe method
        public virtual void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(Description + " Collected, Congrats!!!!");
        }
    }
}