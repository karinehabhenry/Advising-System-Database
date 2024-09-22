<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdvReg.aspx.cs" Inherits="WebApplication1.AdvReg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Advisor Registeration<br />
            <br />
            Advisor Name
            <br />
            <asp:TextBox ID="advn" runat="server"></asp:TextBox>
            <br />
            <br />
            Password<br />
            <asp:TextBox ID="advpass" runat="server"></asp:TextBox>
            <br />
            <br />
            Email</div>
        <asp:TextBox ID="advmail" runat="server"></asp:TextBox>
        <br />
        <br />
        Office<br />
        <asp:TextBox ID="advoff" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="reg" runat="server" Text="Register" OnClick="reg_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Login" OnClick="Button3_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Go To HomePage" OnClick="Button2_Click" />
    </form>
</body>
</html>
