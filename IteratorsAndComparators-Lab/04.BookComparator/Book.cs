using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book

    {

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;

            this.Year = year;

            this.Authors = new List<string>(authors);
        }


        public string Title { get; set; }

        public int Year { get; set; }

        public IReadOnlyList<string> Authors { get; }

        public override string ToString()
        {

            return ($"{this.Title} - {this.Year}");

        }
    }
}

