<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stud_mak1.aspx.cs" Inherits="WebApplication1.stud_mak1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter your Student ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </div>
    <p>
        Enter the Course ID</p>
        &nbsp;<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <p>
            Enter Current Semester</p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" style="height: 29px" />
        </p>
        <asp:Button ID="Button2" runat="server" Text="Student HomePage" OnClick="Button2_Click" />
        <p>
            <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>


