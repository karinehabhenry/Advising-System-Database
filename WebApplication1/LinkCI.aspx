<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LinkCI.aspx.cs" Inherits="WebApplication1.LinkCI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Link Student to Course with a specific Instructor<br />
            <br />
            Course ID:
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            <br />
            <br />
            Instructor ID:
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Student ID:
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester Code:<asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" Text="Admin HomePage" OnClick="Button2_Click1" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" style="height: 29px" />
    </form>
</body>
</html>
