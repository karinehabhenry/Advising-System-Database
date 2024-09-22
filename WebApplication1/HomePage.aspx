<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebApplication1.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Student" OnClick="Studentlogin" />
        </div>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Advisor" />
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button3" runat="server" style="width: 68px" Text="Admin" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>
