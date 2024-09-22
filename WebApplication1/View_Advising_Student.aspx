<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="View_Advising_Student.aspx.cs" Inherits="WebApplication1.View_Advising_Student1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                View my advising students</p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="VIEW" />
        </p>
        <p>
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Go to Advisor HomePage" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="Go to HomePage" OnClick="Button3_Click" />
        </p>
        </div>
    </form>
</body>
</html>
