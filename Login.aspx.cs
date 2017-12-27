using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net.Mail;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session.Remove("mysession");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (txtUsrName.Text.Trim() == "Manager" && txtPasswd.Text.Trim() == "123")
        {
            Session["mysession"] = txtUsrName.Text;
            Response.Redirect("~/HomePage/Home.aspx");
        }
        else 
        {
            lblMsg.Text = "Username or Password does not match";
            lblMsg.ForeColor = System.Drawing.Color.Red;
        }
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        string emailFrom = "fzdsmj1212@gmail.com";
        string emailTo = "soumyajit111maiti@gmail.com";
        MailMessage emailMessage = new MailMessage(emailFrom.ToString(),emailTo.ToString());
        emailMessage.Subject = "Password";
        emailMessage.Body = "Password : 123";
        SmtpClient client = new SmtpClient("smtp.gmail.com",587);
        client.EnableSsl = true;
        client.Credentials = new System.Net.NetworkCredential(emailFrom.ToString(), "farzaadsoumyajit10");
        client.Send(emailMessage);
    }
}