using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
	public abstract class Collectable : Displayable
	{
		public string description;
		public CollectionBoard Board;
		public Collectable(string description)
		{ this.description = description;
		}
		public string Description
		{
			get { return description; }
			set { description = value; }
		}

		public virtual void AddMe(List<Collectable> collection)
		{
			collection.Add(this);
			Console.WriteLine($"{this.Description} Collected, Congrats!!!!");
		}

		public virtual void Display(){}
	}
}