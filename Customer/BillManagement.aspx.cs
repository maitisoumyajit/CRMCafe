using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
public partial class Customer_BillManagement : System.Web.UI.Page
{
    SqlCommand cmd = new SqlCommand();
    SqlConnection con = new SqlConnection();
    DataSet ds = new DataSet();
    SqlDataAdapter da = new SqlDataAdapter();
    public void db()
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        con.Open();
        string str = "Select * from Cust_Bill";
        cmd = new SqlCommand(str,con);
        da = new SqlDataAdapter(cmd);
        da.Fill(ds, "Cust_Bill");
        GridView1.DataSource = ds;
        GridView1.DataBind();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            db();
            con.Close();
        }
    }
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        con.Open();
        string str = "Insert Into Cust_Bill(InvoiceNo,Date,Time,Amount) values(@InvoiceNo,@Date,@Time,@Amount)";
        cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@InvoiceNo",txtInvoice.Text.Trim());
        cmd.Parameters.AddWithValue("@Date",DateTime.Now.ToString("yyyy-MM-dd"));
        cmd.Parameters.AddWithValue("@Time", DateTime.Now.ToString());
        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
        cmd.ExecuteNonQuery();
        con.Close();
        db();
    }
    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        con.Open();
        string str = "Update Cust_Bill set Amount=@Amount where InvoiceNo=@InvoiceNo";
        cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoice.Text.Trim());
        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
        cmd.ExecuteNonQuery();
        con.Close();
        db();
    }
    protected void btnDelete_Click(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ConnectionString);
        con.Open();
        string str = "Delete from Cust_Bill where InvoiceNo=@InvoiceNo";
        cmd = new SqlCommand(str, con);
        cmd.Parameters.AddWithValue("@InvoiceNo", txtInvoice.Text.Trim());
        cmd.Parameters.AddWithValue("@Amount", txtAmount.Text.Trim());
        cmd.ExecuteNonQuery();
        con.Close();
        db();
    }
}