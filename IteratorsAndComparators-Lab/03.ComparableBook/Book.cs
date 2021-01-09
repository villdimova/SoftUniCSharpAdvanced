﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class Book :IComparable<Book>
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

        public int CompareTo(Book other)
        {
            int result = this.Year.CompareTo(other.Year);

            if (result==0)
            {
                result = this.Title.CompareTo(other.Title);
            }

            return result;
        }

        public override string ToString()
        {
  
            return($"{this.Title} - {this.Year}");
 
        }

    }
}
