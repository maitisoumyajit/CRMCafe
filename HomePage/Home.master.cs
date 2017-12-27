using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage_Home : System.Web.UI.MasterPage
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnSignout_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Login.aspx");
    }

    protected void btnAssets_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Assets/Home.aspx");
    }
    protected void btnCustomer_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Customer/Home.aspx");
    }
    protected void btnFinance_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Finance/Home.aspx");
    }
    protected void btnMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Menu/Home.aspx");
    }
    protected void btnStaff_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Staff/StaffDetails.aspx");
    }
}
