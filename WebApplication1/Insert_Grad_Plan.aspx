<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Insert_Grad_Plan.aspx.cs" Inherits="WebApplication1.Insert_Grad_Plan" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Insert Graduation Plan<br />
            <br />
            Semester Code<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Expected Graduation Date<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Semester Credit Hours<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Advisor ID<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Student ID<br />
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Done" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Go to Advisor Page" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go To HomePage" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
