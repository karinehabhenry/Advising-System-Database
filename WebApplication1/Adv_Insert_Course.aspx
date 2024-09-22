<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_Insert_Course.aspx.cs" Inherits="WebApplication1.Adv_Insert_Course" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Add Course for Graduation Plan<br />
            <br />
            Student ID<br />
            <asp:TextBox ID="stuId" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester Code<br />
            <asp:TextBox ID="semcode" runat="server"></asp:TextBox>
            <br />
            <br />
            Course Name<br />
            <asp:TextBox ID="cname" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go To HomePage" />
            <br />
            <br />
        </div>
        <asp:Button ID="Button3" runat="server" Text="Go To Advisor Page" OnClick="Button3_Click" />
    </form>
</body>
</html>
