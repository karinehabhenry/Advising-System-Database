<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddSem.aspx.cs" Inherits="WebApplication1.AddSem" %>

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
            Add New Semester
            <br />
            <br />
            Start date:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            End Date:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester Code:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />

            <br />

            <br />
            <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />

        </div>
    </form>
</body>
</html>
