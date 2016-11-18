using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLayer
{
    public class UsersBridgeLayer
    {
        public IEnumerable<User> Users
        {
            get
            {
                string connectionString =
                    ConfigurationManager.ConnectionStrings["DNNConnection"].ConnectionString;

                List<User> users = new List<User>();

                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("spGetAllUsers", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        User user = new User();
                        user.firstName = rdr["firstName"].ToString();
                        user.lastName = rdr["lastName"].ToString();
                        user.userName = rdr["userName"].ToString();
                        user.email = rdr["email"].ToString();
                        user.joined = Convert.ToDateTime(rdr["joined"]);

                        users.Add(user);
                    }
                }

                return users;
            }
        }

        public void AddUser(User user)
        {
            string connectionString =
                        ConfigurationManager.ConnectionStrings["DNNConnection"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("spAddUser", con);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlParameter paramFirstName = new SqlParameter();
                paramFirstName.ParameterName = "@firstName";
                paramFirstName.Value = user.firstName;
                cmd.Parameters.Add(paramFirstName);

                SqlParameter paramLastName = new SqlParameter();
                paramLastName.ParameterName = "@lastName";
                paramLastName.Value = user.lastName;
                cmd.Parameters.Add(paramLastName);

                SqlParameter paramUsername = new SqlParameter();
                paramUsername.ParameterName = "@userName";
                paramUsername.Value = user.userName;
                cmd.Parameters.Add(paramUsername);

                SqlParameter paramEmail = new SqlParameter();
                paramEmail.ParameterName = "@email";
                paramEmail.Value = user.email;
                cmd.Parameters.Add(paramEmail);

                //This parameter will get system date and store it into the database without the user entering the date
                SqlParameter paramJoined = new SqlParameter();
                paramJoined.ParameterName = "@joined";
                paramJoined.Value = DateTime.Today;
                cmd.Parameters.Add(paramJoined);

                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
