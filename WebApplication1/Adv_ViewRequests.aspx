<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_ViewRequests.aspx.cs" Inherits="WebApplication1.Adv_ViewRequests" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            View All Requests
            <br />
            <br />
            Advisor ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />

            
                        <p>
    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
</p>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go To Advisor HomePage" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button3" runat="server" Text="Go To HomePage" OnClick="Button3_Click" />
    </form>
</body>
</html>
