using System;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Security;
using System.Drawing;
using System.IO;

public partial class _Default : Page
{
    public static string yanzhen = "";
    public string RandNum(int codenum)
    {
        string result = "";
        string[] codechar = new string[46]{"0","1","2","3","4","5","6","7","8","9","A","B","C","D","E","F","0","1","2","3","4","5","6","7","8","9","G","H","I","J","K",
            "L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};
        Random rand = new Random();
        for (int i = 1; i <= codenum; i++)
        {
            int j = rand.Next(codechar.Length);
            result += codechar[j];
        }
        return result;
    }
    public void createimage(string randnum)
    {
        int iwidth = randnum.Length * 13;
        Bitmap image = new Bitmap(iwidth, 23);
        Graphics g = Graphics.FromImage(image);
        g.Clear(Color.White);
        Color[] color = { Color.Green, Color.Red, Color.Black, Color.Blue, Color.Orange };
        string[] font = { "宋体", "黑体", "Verdana", "Microsoft Sans Serif", "Comic Sans MS", "Arial" };
        Random rand = new Random();
        for (int i = 0; i < 50; i++)
        {
            int x = rand.Next(image.Width);
            int y = rand.Next(image.Height);
            g.DrawRectangle(new Pen(Color.LightGray, 0), x, y, 1, 1);
        }
        for (int i = 0; i < randnum.Length; i++)
        {
            int m = rand.Next(5);
            int n = rand.Next(6);
            Color c = color[m];
            Font f = new Font(font[n], 10, System.Drawing.FontStyle.Bold);
            Brush b = new SolidBrush(color[m]);
            g.DrawString(randnum.Substring(i, 1), f, b, 3 + (i * 12), 0);
        }
        g.DrawRectangle(new Pen(Color.DarkGray, 0), 0, 0, image.Width - 1, image.Height - 1);

        image.Save(@"D:\Visual Studio 2013\WebSites\netsec\12.gif", System.Drawing.Imaging.ImageFormat.Gif);

        g.Dispose();
        image.Dispose();

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }
   
  
    protected void Button1_Click1(object sender, EventArgs e)
    {
        string str = RandNum(4);
        createimage(str);
        Image1.ImageUrl = "12.gif";
        yanzhen = str;
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("default3.aspx");
    }
    protected void Button2_Click1(object sender, EventArgs e)
    {
         if (TextBox3.Text.ToString().Trim().ToLower() == yanzhen.ToLower ())
        {

            string txtusername = TextBox1.Text.Trim ();
            string txtpsw = TextBox2.Text.Trim ();
            string constr = @"Data Source=.;Initial Catalog=UserDB;Integrated Security=True;Pooling=False";
            SqlConnection conn = new SqlConnection(constr);
            conn.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select * from person where username=@username and userpsw=@userpsw";
            txtpsw = FormsAuthentication.HashPasswordForStoringInConfigFile(txtpsw, "md5");
           
            cmd.Parameters.Add(new SqlParameter("@username", txtusername));
            cmd.Parameters.Add(new SqlParameter("@userpsw", txtpsw));
            
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr != null)
            {
                Response.Write("登录成功！");
            }

        }
        else
            Response.Write("验证码不正确！");
    }
     
    protected void TextBox2_TextChanged1(object sender, EventArgs e)
    {
        string str = RandNum(4);
        createimage(str);
        Image1.ImageUrl = "12.gif";
        yanzhen = str;
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}

