<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewIC.aspx.cs" Inherits="WebApplication1.ViewIC" %>

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
            <br />
            View All details of instructors Along with their assigned courses<br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" />

            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Admin HomePage" OnClick="Button2_Click" />

            <br />

        </div>
        <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
    </form>
</body>
</html>
