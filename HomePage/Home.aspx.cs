using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["mysession"] ==null)
        {
            Response.Redirect("~/Login.aspx");
        }
        else
        {
            //Response.Write("Welcome "+Session["mysession"]);
            //Session.Remove("mysession");
        }
    }
}