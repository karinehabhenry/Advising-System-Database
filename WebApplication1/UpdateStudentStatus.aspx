<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateStudentStatus.aspx.cs" Inherits="WebApplication1.UpdateStudentStatus" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Student ID:<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
     </div>
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Admin HomePage" OnClick="Button2_Click" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
    </form>
</body>
</html>
