using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace WebApplication4.Controls
{
    public partial class AddUser : System.Web.UI.UserControl
    {

        protected void Page_Load(object sender, EventArgs e)
        {
   
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("Insert into AltKullanicilar(CompanyName,ContactName,ContactTitle,City,PostalCode)VALUES(@CompanyName,@ContactName,@ContactTitle,@City,@PostalCode)", con);
                command.Parameters.AddWithValue("@CompanyName", CompanyName.Text);
                command.Parameters.AddWithValue("@ContactName", ContactName.Text);
                command.Parameters.AddWithValue("@ContactTitle", ContactTitle.Text);
                command.Parameters.AddWithValue("@City", City.Text);
                command.Parameters.AddWithValue("@PostalCode", PostalCode.Text);

                try
                {
                    con.Open();
                    int affectedRows = command.ExecuteNonQuery();

                    if (affectedRows > 0)
                    {
                        Response.Write("User Added");
                    }
                    else
                    {
                        Response.Write("User could not be added");
                    }
                }
                catch (Exception ex)
                {
                    Response.Write("An error occurred: " + ex.Message);
                }
            }
        }


    }
}
