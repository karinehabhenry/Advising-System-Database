<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PendingReq.aspx.cs" Inherits="WebApplication1.PendingReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        <asp:Button ID="Button1" runat="server" Text="List All Pending Requests" OnClick="Button1_Click" />
                    <br />
        <div>
            <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click1" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
        </div>
    </form>
</body>
</html>
