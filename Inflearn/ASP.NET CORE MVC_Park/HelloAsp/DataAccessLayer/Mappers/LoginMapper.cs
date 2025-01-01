using DataAccessLayer.Mappers;
using DataAccessLayer.Models;

using System.Data.SqlClient;


namespace DataAccessLayer.Mappers
{
    public class LoginMapper : ILoginMapper
    {
        public LoginMapper(string conn)
        {
            connectionString = conn;
        }
        private string connectionString;

        public async Task<USER> Create(USER user)
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "INSERT INTO TBL_USER(USERID ,USERNAME, POINT) OUTPUT INSERTED.ID VALUES(@userid,@username,@point)";
                    sqlCommand.Parameters.AddWithValue("@userid", user.Userid);
                    sqlCommand.Parameters.AddWithValue("@username", user.UserName);
                    sqlCommand.Parameters.AddWithValue("@point", user.Point);
                    int id = Convert.ToInt32(await sqlCommand.ExecuteScalarAsync());
                    user.Id = id;

                    return user;
                }
            }
            catch (Exception ex)
            {
                throw;
            }

        }


        public async Task<List<USER>> GetAll()
        {
            try
            {
                List<USER> LIST = new List<USER>();
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    await sqlConnection.OpenAsync();
                    SqlCommand sqlCommand = sqlConnection.CreateCommand();
                    sqlCommand.CommandText = "SELECT * FROM [MyTestDB].[dbo].[TBL_USER] ";
                    SqlDataReader reader = await sqlCommand.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {

                            USER usr =  new USER
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("ID")),
                                Userid = reader.GetString(reader.GetOrdinal("USERNAME")),
                                UserName = reader.GetString(reader.GetOrdinal("USERNAME")),
                                Point = reader.GetInt32(reader.GetOrdinal("POINT"))
                            };

                            LIST.Add(usr);
                        }
                    }
                    reader.Close();
                }
                return LIST;
            }
            catch (Exception ex)
            {
                throw;
            }

        }


    }
}
