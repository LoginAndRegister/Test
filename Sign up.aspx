<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div  style="background-color:#0cf5bc; height:248px; width:264px">
    
        <b>用户注册</b><br />
        <br />
        用户名：<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
         <br />
        <br />
        密码： <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
         &nbsp; 
        <br />
        <br />
        真实的名字：<asp:TextBox ID="TextBox3" runat="server" Width="109px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="注册" OnClick="Button3_Click" />
        
        <br />
        <br />
&nbsp;&nbsp;
                
        <div>
    
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </div>
        
    
    
    </div>
    </form>
</body>
</html>
