using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Security;
using System.Configuration;
using System.Collections;
using System.Data;
using System.Web.Security;

public partial class Default3 : System.Web.UI.Page
{
  
    protected void Button3_Click(object sender, EventArgs e)
    {
        string txtusername = TextBox1.Text;
        string txtuserpsw = TextBox2.Text;
        string txtrealname = TextBox3.Text;
        txtuserpsw = FormsAuthentication.HashPasswordForStoringInConfigFile(txtuserpsw, "md5");
        string constr = @"Data Source=.;Initial Catalog=UserDB;Integrated Security=True;Pooling=False";
        SqlConnection conn = new SqlConnection(constr);
        conn.Open();
        SqlCommand cmd = new SqlCommand();
        cmd.Connection = conn;
        cmd.CommandText = "insert into person(username,userpsw,userrealname) values(@username,@userpsw,@userrealname)";
        cmd.Parameters.Add(new SqlParameter("@username", txtusername));
        cmd.Parameters.Add(new SqlParameter("@userpsw", txtuserpsw));
        cmd.Parameters.Add(new SqlParameter("@userrealname", txtrealname));
        cmd.ExecuteNonQuery();

        SqlCommand cmdquery = new SqlCommand();
        cmdquery.Connection = conn;
        cmdquery.CommandText = "select * from person";
        GridView1.DataSource = cmdquery.ExecuteReader();
        GridView1.DataBind();
    }

}
