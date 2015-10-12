using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class Default2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        string txtusername = TextBox1.Text;

        string constr = @"Data Source=.;Initial Catalog=UserDB;Integrated Security=True;Pooling=False";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "select * from person where username=@username";
        cmd.Parameters.Add(new SqlParameter("@username", txtusername));
        Response.Write(cmd.CommandText);
        GridView1.DataSource = cmd.ExecuteReader();
        GridView1.DataBind();
    }
}
