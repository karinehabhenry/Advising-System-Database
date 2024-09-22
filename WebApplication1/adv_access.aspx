<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Adv_Access.aspx.cs" Inherits="WebApplication1.Adv_Access" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button1" runat="server" Text="View Advising Students"  OnClick="ViewAdvStu"/>
        <br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="Insert Graduation Plan"  OnClick="InsertGrad" />
        <p>
            <asp:Button ID="Button3" runat="server" Text="      Insert Course      " OnClick="Button3_Click" />
        </p>
        <asp:Button ID="Button4" runat="server" Text="Update Expected Graduation Date" OnClick="Button4_Click" />
        <p>
            <asp:Button ID="Button5" runat="server" Text="Delete Course" OnClick="Button5_Click" />
        </p>
        <asp:Button ID="Button6" runat="server" Text="View Assigned Students" OnClick="Button6_Click" />
        <p>
            <asp:Button ID="Button7" runat="server" Text="View All Requests" OnClick="Button7_Click" />
        </p>
        <asp:Button ID="Button8" runat="server" Text="View All Pending Requests" OnClick="Button8_Click" />
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" Text="Approve/ Reject Extra Credit Hours Request" OnClick="Button9_Click" />
        <br />
        <br />
        <asp:Button ID="Button10" runat="server" Text=" Approve/ Reject Extra Courses Request" OnClick="Button10_Click" />
        <p>
            <asp:Button ID="Button11" runat="server" Text="Go to HomePage" OnClick="Button11_Click" />
        </p>
    </form>
</body>
</html>
