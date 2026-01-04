using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_with_harry
{
    class Book
    {
        public int BookId { get; private set; }
        public string Title { get; private set; }
        public bool IsIssued { get; protected set; }

        public Book(int bookId, string title)
        {
            BookId = bookId;
            Title = title;
            IsIssued = false;
        }

        public virtual void IssueBook()
        {
            IsIssued = true;
        }

        public virtual void ReturnBook()
        {
            IsIssued = false;
        }

        public virtual void Display()
        {
            Console.WriteLine($"BookId: {BookId}, Title: {Title}, Issued: {IsIssued}");
        }
    }

    class ReferenceBook : Book
    {
        public ReferenceBook(int bookId, string title)
            : base(bookId, title)
        {
        }

        public override void IssueBook()
        {
            Console.WriteLine("Reference books cannot be issued.");
        }
    }

    class Member
    {
        public int MemberId { get; private set; }
        public string Name { get; private set; }

        public Member(int memberId, string name)
        {
            MemberId = memberId;
            Name = name;
        }
    }


    class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added successfully.");
        }

        public void AddMember(Member member)
        {
            members.Add(member);
            Console.WriteLine("Member added successfully.");
        }

        public void IssueBook(int bookId)
        {
            Book book = books.Find(b => b.BookId == bookId);
            if (book != null && !book.IsIssued)
            {
                book.IssueBook();
            }
            else
            {
                Console.WriteLine("Book not available.");
            }
        }

        public void ReturnBook(int bookId)
        {
            Book book = books.Find(b => b.BookId == bookId);
            if (book != null && book.IsIssued)
            {
                book.ReturnBook();
                Console.WriteLine("Book returned successfully.");
            }
        }

        public void DisplayAvailableBooks()
        {
            Console.WriteLine("\nAvailable Books:");
            foreach (Book book in books)
            {
                if (!book.IsIssued)
                    book.Display();
            }
        }
    }




    internal class Library_Management_System
    {
        static void Main(string[] args)
        {
            Library library = new Library();

            library.AddBook(new Book(1, "C# Basics"));
            library.AddBook(new ReferenceBook(2, "Encyclopedia"));

            library.AddMember(new Member(101, "Dipak"));

            library.DisplayAvailableBooks();

            library.IssueBook(1);
            library.IssueBook(2);   // Polymorphism example

            library.DisplayAvailableBooks();

            library.ReturnBook(1);
            library.DisplayAvailableBooks();






            Console.ReadLine();
        }
    }
}
