<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminIssuingInstallment.aspx.cs" Inherits="WebApplication1.AdminIssuingInstallment" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Payment ID<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Issue" OnClick="Button1_Click" />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Admin homepage" OnClick="Button2_Click1" />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
        </div>
    </form>
</body>
</html>
