<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stud_choosei.aspx.cs" Inherits="WebApplication1.stud_choosei" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Your Student ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Enter Your Instructor ID<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Enter Your Course ID<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            Enter Current Semester<br />
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="Student Homepage" OnClick="Button2_Click1" />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
        </div>
    </form>
</body>
</html>
