using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Assets_Home : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnElectronics_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Assets/Electronic.aspx");
    }
    protected void btnFurniture_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Assets/Furniture.aspx");
    }
    protected void btnKitchenAppliances_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Assets/KitchenAppliances.aspx");
    }
}