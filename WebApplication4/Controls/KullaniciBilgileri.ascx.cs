using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class KullaniciBilgileri : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    LoadUserData();
                }
            }
            
        }

        private void LoadUserData()
        {
            
            txtName.Text = Session["UserName"].ToString(); 
            txtSurname.Text = Session["UserSurName"].ToString();
            txtEmail.Text = Session["UserEmail"].ToString();
        }

        protected void UpdateButton_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "Update Kullanicilar set Name=@Name, Surname=@Surname, Email=@Email where Id=@Id";
                SqlCommand cmd = new SqlCommand(sqlQuery, con);
                var id = Session["UserId"].ToString();
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Surname", txtSurname.Text);
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                
            }
            LoadUserData();
        }
    }
}