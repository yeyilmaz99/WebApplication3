using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4.Controls
{
    public partial class _default : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Session["UserId"] != null)
                {
                    LoadUserData();
                }

            }
        }

        private void LoadUserData()
        {
            Email.Text = Email.Text +  Session["UserEmail"].ToString();
            Name.Text = Name.Text + Session["UserName"].ToString();
            Surname.Text = Surname.Text + Session["UserSurname"].ToString();
        }
    }
}