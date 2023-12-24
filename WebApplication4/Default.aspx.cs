using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["UserId"] == null)
                {
                    //Response.Redirect("~/Login.aspx");
                }
                string actParam = Request.QueryString["Act"];
                if(actParam == null)
                {
                    PlaceHolder1.Controls.Add(LoadControl("~/Controls/Home.ascx"));
                }
                
            }

        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string actParam = Request.QueryString["Act"];

            if (!string.IsNullOrEmpty(actParam))
            {
                if (actParam.Equals("KullaniciBilgileri"))
                {
                    Control KBC = Page.LoadControl("~/Controls/KullaniciBilgileri.ascx");
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(KBC);
                }
                else if (actParam.Equals("UserList"))
                {
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/Controls/UserList.ascx"));
                }
                else if (actParam.Equals("Home"))
                {
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/Controls/Home.ascx"));
                }
                else if (actParam.Equals("AddUser"))
                {
                    UserControl AddUserControl = (UserControl)Page.LoadControl("~/Controls/AddUser.ascx");
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(AddUserControl);
                }
                else
                {
                    PlaceHolder1.Controls.Clear();
                    PlaceHolder1.Controls.Add(LoadControl("~/Controls/Home.ascx"));
                }

            }
        }
    }
}