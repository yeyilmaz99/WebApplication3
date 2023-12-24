using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebApplication4.Controls
{
    public partial class UserList : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DataTable dataTable = GetData();
                GridView1.DataSource = dataTable;
                GridView1.DataBind();
            }
        }

        private DataTable GetData()
        {
            DataTable dataTable = new DataTable();


            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            string query = "SELECT * FROM AltKullanicilar";

            using (SqlConnection con = new SqlConnection(CS))
            {
                SqlCommand command = new SqlCommand(query, con);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                con.Close();

            }

            return dataTable;
        }
    }
}