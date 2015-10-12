<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>无标题页</title>
</head>
<body>
    <form id="form1" runat="server">
    <div  style="background-color:#1cf241; height:248px; width:264px">
    
        <b>用户登录</b><br />
        <br />
        用户名：<asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"  ></asp:TextBox>
        <br />
        <br />
        密码：&nbsp; 
        <asp:TextBox ID="TextBox2" runat="server" AutoPostBack="True" OnTextChanged="TextBox2_TextChanged1"  
           ></asp:TextBox>
        <br />
        <br />
        验证码：<asp:TextBox ID="TextBox3" runat="server" Width="88px"  style="height: 19px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>
        <asp:Image ID="Image1" runat="server" Height="21px" Width="55px" />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="刷新验证码" OnClick="Button1_Click1"  />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="登录" OnClick="Button2_Click1"  />
&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Text="注册" OnClick="Button3_Click"  />
        
        <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </div>
        
    
    </div>
    </form>
</body>
</html>
