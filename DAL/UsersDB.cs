
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data.SqlClient;
using System.Configuration;

namespace DAL
{
    public class UsersDB : IUsersDB
    {
        /*public IConfiguration Configuration { get; }

        public UsersDB(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        */
        public string connectionString = null;

        public UsersDB()
        {
            connectionString = ConfigurationManager.ConnectionStrings["WebServiceDB"].ConnectionString;
        }

        public List<User> GetUsers()
        {
            List<User> results = null;

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM [User] ORDER BY Username";
                    SqlCommand cmd = new SqlCommand(query, cn);

                    cn.Open();

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (results == null)
                                results = new List<User>();

                            User user = new User();
                            user.IdUser = (int)dr["IdUser"];
                            user.Firstname = (string)dr["Firstname"];
                            user.Lastname = (string)dr["Lastname"];
                            user.Username = (string)dr["Username"];
                            user.Amount = (double)dr["Amount"];

                            results.Add(user);
                        }
                    }
                }

            }catch(Exception e)
            {
                throw e;
            }

            return results;
        }

        public float GetAmountForAStudent(int id)
        {
            float amount = 0;
            //string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using(SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "SELECT Amount FROM [User] where IdUSer = @id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);

                    cn.Open();

                    using(SqlDataReader dr = cmd.ExecuteReader())
                    {
                        amount = (float)dr["Amount"];
                    }
                }
            }catch(Exception e)
            {
                throw e;
            }
            return amount;
        }

        public int UpdateAmountViaId(int id, double amount)
        {
            int result = 0;
            //string connectionString = Configuration.GetConnectionString("DefaultConnection");
            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [User] SET Amount=@amount WHERE IdUser=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int UpdateAmountViaUsername(string username, double amount)
        {
            int result = 0;
            //string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [User] SET Amount=@amount WHERE Username=@username";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = username;
                    cmd.Parameters.AddWithValue("@amount", amount);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return result;
        }

        public int UpdateAmount(User user)
        {
            int result = 0;
            //string connectionString = Configuration.GetConnectionString("DefaultConnection");

            try
            {
                using(SqlConnection cn = new SqlConnection(connectionString))
                {
                    string query = "UPDATE [User] SET Amount=@amount WHERE IdUser=@id";
                    SqlCommand cmd = new SqlCommand(query, cn);
                    cmd.Parameters.AddWithValue("@id", user.IdUser);
                    cmd.Parameters.AddWithValue("@amount", user.Amount);

                    cn.Open();

                    result = cmd.ExecuteNonQuery();
                }
            }
            catch(Exception e)
            {
                throw e;
            }

            return result;
        }
    }
}
