using DataAccessLayer.Mappers;
using HelloAsp.Models;
using System.Data.SqlClient;


namespace HelloAsp.DAL
{
    public class LoginMapper : ILoginMapper
    {
        private string connectionString = "Data Source=127.0.0.1,1433;Initial Catalog=MyTestDB;User ID=sa;Password=qwe123!@#;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False";

        public async Task<USER> Create(USER user)
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                await sqlConnection.OpenAsync();
                SqlCommand sqlCommand = sqlConnection.CreateCommand();
                sqlCommand.CommandText = "INSERT INTO TBL_USER(USERID ,USERNAME, POINT) OUTPUT INSERTER.ID IN VALUES(@userid,@username,@point)";
                sqlCommand.Parameters.AddWithValue("@userid",user.Userid);
                sqlCommand.Parameters.AddWithValue("@username", user.UserName);
                sqlCommand.Parameters.AddWithValue("@point", user.Point);
                int id = Convert.ToInt32( await sqlCommand.ExecuteScalarAsync());
                user.Id = id;

                return user;

             


            }
        }


    }
}
