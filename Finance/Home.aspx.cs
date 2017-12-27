using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Finance_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnGoods_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Finance/Goods.aspx");
    }
    protected void btnBills_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Finance/Bills.aspx");
    }
    protected void btnSalary_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Finance/Salary.aspx");
    }
    protected void btnAccounts_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Finance/Accounts.aspx");
    }
}