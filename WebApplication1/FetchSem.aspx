<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FetchSem.aspx.cs" Inherits="WebApplication1.FetchSem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </div>
        <p>
            Fetch All Semesters Along with their offered courses</p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click1" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
        </p>
    </form>
</body>
</html>
