<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_DeleteCourse.aspx.cs" Inherits="WebApplication1.Adv_DeleteCourse2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Delete Course From a graduation plan from a certain semester<br />
            <br />
            Student ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester Code<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Course ID<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Delete" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Go to Advisor HomePage" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Go to HomePage" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
