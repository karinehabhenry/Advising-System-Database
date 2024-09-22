<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_UpdateGDate.aspx.cs" Inherits="WebApplication1.Adv_UpdateGDate" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Update expected graduation date in a certain graduation plan<br />
            <br />
            Expected Graduation Date</div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        Student ID<br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Update" OnClick="Button1_Click" />
        <br />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Go To Advisor HomePage" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Go To HomePage" OnClick="Button3_Click" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
