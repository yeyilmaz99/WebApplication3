using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace WebApplication4
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HyperLink1.NavigateUrl = "~/Register.aspx";
            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("getKullanici", con);
                cmd.Parameters.AddWithValue("@Email", Email.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataReader reader = cmd.ExecuteReader();
                User user = new User();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        
                        user.Email = reader.GetString(reader.GetOrdinal("Email"));
                        user.Id = reader.GetInt32(reader.GetOrdinal("Id"));
                        user.Name = reader.GetString(reader.GetOrdinal("Name"));
                        user.Surname = reader.GetString(reader.GetOrdinal("Surname"));
                        user.Password = reader.GetString(reader.GetOrdinal("Password"));
                        
                    }
                    Session["UserId"] = user.Id;
                    Session["UserName"] = user.Name;
                    Session["UserSurname"] = user.Surname;
                    Session["UserEmail"] = user.Email;
                    Response.Redirect("Default.aspx");

                }
                else
                {
                    Response.Write("KULLANICI BULUNAMADI");
                }

                reader.Close();
                con.Close();

            }
        }
    }

    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; } 

    }
}