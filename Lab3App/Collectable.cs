using System;
using System.Collections.Generic;
namespace Lab3App
{
    public abstract class Collectable : Displayable
    {
        public string description;
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public CollectionBoard board;
        public CollectionBoard Board
        {
            get { return board; }
            set { board = value; }
        }

        public Collectable(string description)
        {
            this.description = description;
        }

        public abstract void Display();

        public void AddMe(List<Collectable> list)
        {
            list.Add(this);
            Console.WriteLine(this.description + " Collected, Congrats!!!!");
        }
}