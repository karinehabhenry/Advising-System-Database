<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewGPWithAdvisors.aspx.cs" Inherits="WebApplication1.ViewGPWithAdvisors" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>

            <br />
            View all graduation plans along with their initiated advisors<br />

        </div>
        <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Admin HomePage" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
