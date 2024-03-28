using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsHW.Task1
{
    internal class Inventory
    {
        public Inventory(string author, string title, string year)
        {
            Author = author;
            Title = title;
            Year = year;
        }

        public int ID { get; private set; } = new Random().Next();

        public string Title { get; set; }

        public string Author { get; set; }

        public string Year { get; set; }

        protected bool Equals(Inventory other)
        {
            return ID == other.ID
                && Author == other.Author
                && Title == other.Title
                && Year == other.Year;
        }

        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;
            return Equals((Inventory)obj);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(ID, Author, Title, Year);
        }
    }
}
