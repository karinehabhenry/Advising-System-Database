<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewM.aspx.cs" Inherits="WebApplication1.viewM" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID</div>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="View Missing Course" Width="169px" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Go to Student Page" OnClick="Button3_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Go to Homepage" OnClick="Button2_Click" Height="23px" Width="212px" />
        </p>
    </form>
</body>
</html>
