<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkICS.aspx.cs" Inherits="WebApplication1.LinkICS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Link Instructor to Course On a Specific Slot<br />
            <br />
            Course ID:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Instructor ID:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Slot ID:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click1" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
        </div>
    </form>
</body>
</html>
