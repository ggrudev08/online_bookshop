

using Microsoft.Data.SqlClient;
using OnlineBookshop.Business;
using OnlineBookshop.Data.Models;
using OnlineBookshop.Presentation;

namespace OnlineBookshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Display display = new Display();
            SqlConnection dbCon = new SqlConnection(
                "Server=(localdb)\\MSSQLLocalDB; " +
                "Database=online_bookshop; " +
                "Integrated Security=true");
            dbCon.Open();
            using (dbCon)
            {
                
            }
            dbCon.Close();

        }
    }
}