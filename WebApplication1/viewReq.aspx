<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewReq.aspx.cs" Inherits="WebApplication1.viewReq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">
        <div>
            <br />
            Student ID<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Semester<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="view required courses" OnClick="Button1_Click" />
        <br />
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        
        
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
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
