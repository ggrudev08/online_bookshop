

using Microsoft.Data.SqlClient;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;

namespace OnlineBookshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection dbCon = new SqlConnection(
                "Server=(localdb)\\MSSQLLocalDB; " +
                "Database=online_bookshop; " +
                "Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                AuthorBusiness ab = new AuthorBusiness();
                foreach (var author in ab.GetAll())
                {
                    Console.WriteLine($"{author.AuthorId} {author.FirstName + " "+author.LastName} {author.BirthYear}");
                }
            }
            dbCon.Close();

        }
    }
}
