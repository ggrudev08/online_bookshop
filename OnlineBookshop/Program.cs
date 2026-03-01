

using Microsoft.Data.SqlClient;

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
                //------------ Insert Query -----------
                string? first_name = Console.ReadLine();
                string? last_name = Console.ReadLine();
                int? birth_year = int.Parse(Console.ReadLine());

                string insertAuthors = $"insert into authors(first_name, last_name, birth_year) values (@first_name, @last_name, @birth_year);";
                var commandInsert = new SqlCommand(insertAuthors, dbCon);

                commandInsert.Parameters.AddWithValue("@first_name", first_name);
                commandInsert.Parameters.AddWithValue("@last_name", last_name);
                commandInsert.Parameters.AddWithValue("@birth_year", birth_year);

                commandInsert.ExecuteNonQuery();

                //----------- Print Query ----------------
                string select = "select * from authors;";

                SqlCommand command = new SqlCommand(select, dbCon);
                using var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine($"{reader[0]} {reader[1]} {reader[2]} {reader[3]}");
                }
            }
            dbCon.Close();

        }
    }
}
