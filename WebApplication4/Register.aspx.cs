using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                HyperLink1.NavigateUrl = "~/Login.aspx";
            }
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand("addKullanici", con);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Name", Name.Text);
                command.Parameters.AddWithValue("@Surname", Surname.Text);
                command.Parameters.AddWithValue("@Email", Email.Text);
                command.Parameters.AddWithValue("@Password", Password.Text);
                con.Open();
                var affectedRows = command.ExecuteNonQuery();

                if(affectedRows > 0)
                {
                    Response.Redirect("~/Login.aspx");
                }
                else
                {
                    Response.Write("Kullanici eklenemedi");
                }

            }
        }
    }
}