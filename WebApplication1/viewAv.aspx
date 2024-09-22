<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewAv.aspx.cs" Inherits="WebApplication1.viewAv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
              
<p>
    View Available Courses</p>
        <p>
            Semester Code</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button4" runat="server" Text="View" OnClick="Button4_Click" />
        </p>
        <p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
        <p>
            &nbsp;</p>
<p>
    <asp:Button ID="Button3" runat="server" Text="Go to Student Page" OnClick="Button3_Click" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" Text="Go to Homepage" OnClick="Button2_Click" Height="23px" Width="212px" />
</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
