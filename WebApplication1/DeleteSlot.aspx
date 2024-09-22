<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeleteSlot.aspx.cs" Inherits="WebApplication1.DeleteSlot" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Current Semester code<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click1" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
    </form>
</body>
</html>
