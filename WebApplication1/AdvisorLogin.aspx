<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvisorLogin.aspx.cs" Inherits="WebApplication1.AdvisorLogin" %>

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
            <asp:TextBox ID="AdvID" runat="server"></asp:TextBox>
            <br />
            <br />
            Password</div>
        <asp:TextBox ID="AdvPass" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
                <br />
        <br />
        <br />
                Don&#39;t have an account?<br />
        <asp:Button ID="Button2" runat="server" Text="Register" Height="29px" OnClick="reg" Width="73px" />
        <br />
        <br />
        <br />
        
    
        <asp:Button ID="Button3" runat="server" Text="Home" OnClick="Button3_Click" />
  

    </form>
</body>
</html>
