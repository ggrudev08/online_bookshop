using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookshop.Presentation
{
    public class AuthorDisplay
    { private AuthorBusiness _authorBusiness;

        public AuthorDisplay()
        {
            _authorBusiness = new AuthorBusiness();
            Input();
        }

        private void Heading()
        {
            Console.WriteLine(new string('=', 50));
            Console.WriteLine(new string(' ', 20) + "Authors" + new string(' ', 20));
            Console.WriteLine(new string('=', 50));
        }
        private void ShowMenu()
        {
            Heading();

            Console.WriteLine("1. All authors");
            Console.WriteLine("2. Add new author");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Fetch author by ID");
            Console.WriteLine("5. Delete author by ID");
            Console.WriteLine("6. Exit");
        }

        private void Input()
        {
            bool isRunning = true;
            while (isRunning)
            {
                ShowMenu();
                Console.WriteLine("Enter operation ID: ");
                int operation = int.Parse(Console.ReadLine());

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
                    
                    case 6:
                        isRunning = false;
                        break;

                }
                
            }
        }

        private void Delete()
        {
            Console.WriteLine("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine()); 
            _authorBusiness.Delete(id);
            Console.WriteLine("Done");
        }
        
        private void Fetch()
        {
            Console.WriteLine("Enter ID to fetch: ");
            int id = int.Parse(Console.ReadLine());
            var author = _authorBusiness.Get(id);

            if (author != null)
            {
                Console.WriteLine(new string('=', 50));

                Console.WriteLine($"ID: {author.AuthorId}");
                Console.WriteLine($"First name: {author.FirstName}");
                Console.WriteLine($"Last name: {author.LastName}");
                Console.WriteLine($"Birth year: {author.BirthYear}");

                Console.WriteLine(new string('=', 50));
            }
        }

        private void Update()
        {
            Console.WriteLine("Enter ID to update: ");
            int id = int.Parse(Console.ReadLine());
            var author = _authorBusiness.Get(id);

            if (author != null)
            {
                Console.WriteLine("Enter new first name: ");
                author.FirstName = Console.ReadLine();
                Console.WriteLine("Enter new last name: ");
                author.LastName = Console.ReadLine();
                Console.WriteLine("Enter new birth year: ");
                author.BirthYear = int.Parse(Console.ReadLine());

                _authorBusiness.Update(author);

                Console.WriteLine("Done");
            }


        }
        private void Add()
        {
            Author author = new Author();
            Console.WriteLine("Enter first name: ");
            author.FirstName = Console.ReadLine();
            Console.WriteLine("Enter last name: ");
            author.LastName = Console.ReadLine();
            Console.WriteLine("Enter birth year: ");
            author.BirthYear = int.Parse(Console.ReadLine());

            _authorBusiness.Add(author);
            Console.WriteLine("Done");

        }

        private void AllList()
        {
            Heading();
            var authors = _authorBusiness.GetAll();

            foreach (var item in authors)
            {
                Console.WriteLine($"ID: {item.AuthorId} | First Name: {item.FirstName} | Last Name: {item.LastName} | Birth Year: {item.BirthYear}");
            }

        }

    }
}