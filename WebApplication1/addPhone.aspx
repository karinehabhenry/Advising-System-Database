<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addPhone.aspx.cs" Inherits="WebApplication1.addPhone" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>






            Student Id</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        Mobile Number<p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="Button1" runat="server" Text="insert phone number" OnClick="Button1_Click" />
        
        
<p>
    &nbsp;</p<%-->--%>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    <asp:Button ID="Button3" runat="server" Text="Go to Student Page" OnClick="Button3_Click" />
</p>
<p>
    <asp:Button ID="Button2" runat="server" Text="Go to Homepage" OnClick="Button2_Click" Height="23px" Width="212px" />
</p>
    </form>
</body>
</html>
