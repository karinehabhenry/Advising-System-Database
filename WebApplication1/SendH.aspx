<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SendH.aspx.cs" Inherits="WebApplication1.SendH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p>
            StudentID
        </p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;Credit Hours
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;Type </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            &nbsp;comment </p>
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        <br />
        <p>
        <asp:Button ID="Button1" runat="server" Text="send" Height="32px" OnClick="Button1_Click" Width="167px" />
        &nbsp;
        </p>
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
