using Dapper;
using System.Data.SqlClient;
using wintership_2024_dotNET.DAL.Dtos;

namespace DemoExercise2.Repository
{
    public class AccountRepository
    {

        public List<AccoutDto> GetAccounts()
        {
            string connectionString = "Server=(localdb)\\internship; Initial Catalog=Wintership2024; Integrated Security=true;TrustServerCertificate=True";
            using (var connection = new SqlConnection(connectionString)) 
            {
                var sql_account = "SELECT * FROM dbo.Account";
                return connection.Query<AccoutDto>(sql_account).ToList();
                
            }
        }
    }
}
