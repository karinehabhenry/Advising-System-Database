<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_ViewAssignedStu.aspx.cs" Inherits="WebApplication1.Adv_ViewAssignedStu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;View assigned students from a certain major
            <br />
            <br />
&nbsp;Advisor ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Major<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
             <p>
     <asp:Literal ID="Literal1" runat="server"></asp:Literal>
 </p>
        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Go To Advisor HomePage" OnClick="Button2_Click" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="Go to HomePage" OnClick="Button3_Click" style="height: 29px" />
    </form>
</body>
</html>
