<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminLogin.aspx.cs" Inherits="WebApplication1.AdminLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Admin Login <br />
    <br />
    ID<br />
    <asp:TextBox ID="AdmID" runat="server"></asp:TextBox>
    <br />
    <br />
    Password</div>
<asp:TextBox ID="AdmPass" runat="server"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />

        <br />
        <br />

    </form>
</body>
</html>
