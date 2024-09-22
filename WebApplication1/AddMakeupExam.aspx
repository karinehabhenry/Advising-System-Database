<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddMakeupExam.aspx.cs" Inherits="WebApplication1.AddMakeupExam" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Type:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            Date:<asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            Course ID:<asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </div>
        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Admin HomePage" OnClick="Button2_Click" />
        <p>
            <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>
