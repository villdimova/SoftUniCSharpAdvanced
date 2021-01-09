using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private List<Book> books;

        public Library(params Book[] books)
        {
            this.books = new List<Book>(books);
            this.books.Sort(new BookComparator());

            
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return new LibraryIterator(this.books);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        private class LibraryIterator : IEnumerator<Book>
        {
            private readonly List<Book> books;
            private int currentIndex;

            public LibraryIterator(IEnumerable<Book> books)
            {
                this.Reset();
                this.books = new List<Book>(books);
            }
            public void Dispose() { }
            public bool MoveNext()
            {
                this.currentIndex++;
                if (currentIndex >= this.books.Count)
                {
                    return false;
                }

                return true;
            }
            public void Reset() => this.currentIndex = -1;
            public Book Current => this.books[currentIndex];
            object IEnumerator.Current => this.Current;

        }
    }


}

