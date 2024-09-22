<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="student_gpas.aspx.cs" Inherits="WebApplication1.student_gpas" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <div>
    <form id="form1" runat="server">
        <p>
            Enter your Student ID

        </p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
         <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Stduent Homepage" OnClick="Button2_Click1" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />
    </form>
        </div>
</body>
</html>
