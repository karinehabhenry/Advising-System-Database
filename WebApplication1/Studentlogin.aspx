<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Studentlogin.aspx.cs" Inherits="WebApplication1.Studentlogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Login<br />
            <br />
            ID<br />
            <asp:TextBox ID="stuser" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="stpass" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Studentloginn" Text="Login" />
            <br />
            <br />
            Don&#39;t have an account?<br />
            <asp:Button ID="Button2" runat="server" Text="Register" Height="29px" OnClick="reg" Width="73px" />
            <br />
            <br />
            <br />
        
  
    <asp:Button ID="Button4" runat="server" Text="Go to Homepage" OnClick="Button2_Click" Height="23px" Width="212px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button5" runat="server" Text="Student Homepage" OnClick="Button5_Click" />
            <br />
            <br />
            <br />
        </div>
        
  
    </form>
</body>
</html>
