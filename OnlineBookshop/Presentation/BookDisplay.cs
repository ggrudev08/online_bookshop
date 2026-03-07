using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Presentation
{
    internal class BookDisplay
    {


        int closeOperationId = 6;
        private BookBusiness bookBusiness = new BookBusiness();

        public BookDisplay()
        {
            Input();
        }
        private void ShowMenu()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Books" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("1. All books");
            Console.WriteLine("2. Add new book");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Fetch book by ID");
            Console.WriteLine("5. Delete book by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {

            var operation = -1;
            do
            {
                ShowMenu();
                operation = int.Parse(Console.ReadLine());
                switch (operation)
                {
                    case 1:
                        AllList();
                        break;
                    case 2:
                        Add();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Fetch();
                        break;
                    case 5:
                        Delete();
                        break;
                    default:
                        break;
                }

            } while (operation != closeOperationId);
        }
        private void AllList()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Books" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));

            var book = bookBusiness.GetAll();
            foreach (var intem in book)
            {
                Console.WriteLine($"ID: {intem.BookId} | Name: {intem.BookName} | Genre: {intem.Genre} | Price: {intem.Price} | Release Year: {intem.ReleaseYear}");
            }
        }
        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());
            bookBusiness.Delete(id);
            Console.WriteLine("Done.");
        }
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            var book = bookBusiness.Get(id);
            if (book != null)
            {
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("ID: " + book.BookId);
                Console.WriteLine("Name: " + book.BookName);
                Console.WriteLine("Genre: " + book.Genre);
                Console.WriteLine("Price: " + book.Price);
                Console.WriteLine("Release Year: " + book.ReleaseYear);
                Console.WriteLine(new string('=', 50));

            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var book = bookBusiness.Get(id);
            if (book != null)
            {
                Console.WriteLine("Enter new name: ");
                book.BookName = Console.ReadLine();
                Console.WriteLine("Enter new genre: ");
                book.Genre = Console.ReadLine();
                Console.WriteLine("Enter new price: ");
                book.Price = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter new release year: ");
                book.ReleaseYear = int.Parse(Console.ReadLine());
                bookBusiness.Update(book);
                Console.WriteLine("Done.");
            }
        }

        private void Add()
        {
            Book book = new Book();
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter genre: ");
            string genre = Console.ReadLine();
            Console.WriteLine("Enter price: ");
            decimal price = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Enter release year: ");
            int releaseYear = int.Parse(Console.ReadLine());
            bookBusiness.Add(book);
            Console.WriteLine("Done.");
        }

    }

}