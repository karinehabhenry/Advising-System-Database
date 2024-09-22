<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_A-RCreditH.aspx.cs" Inherits="WebApplication1.Adv_A_RCreditH" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Approve or Reject Extra Credit Hours Requests
            <br />
            <br />
            Request ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Current Semester Code
            <br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Text="Accept/Reject" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Go To Advisor HomePage" OnClick="Button1_Click" />
            <br />
        </div>
        <asp:Button ID="Button2" runat="server" Text="Go To HomePage" OnClick="Button2_Click" />
    </form>
</body>
</html>
