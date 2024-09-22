<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Student_Registration.aspx.cs" Inherits="WebApplication1.Student_Registration1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Register then go to Login Page<br />
        </div>
        First Name<br />
        <asp:TextBox ID="fn" runat="server"></asp:TextBox>
        <br />
        <br />
        Last Name<br />
        <asp:TextBox ID="ln" runat="server"></asp:TextBox>
        <br />
        <br />
        Password<br />
        <asp:TextBox ID="ps" runat="server"></asp:TextBox>
        <br />
        <br />
        Mail<br />
        <asp:TextBox ID="mail" runat="server"></asp:TextBox>
        <br />
        <br />
        Major<br />
        <asp:TextBox ID="maj" runat="server"></asp:TextBox>
        <br />
        <br />
        Faculty
        <br />
        <asp:TextBox ID="fac" runat="server"></asp:TextBox>
        <br />
        <br />
        Semester<br />
        <asp:TextBox ID="sem" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="register" Text="Register" />
        <br />
        <br />
        <asp:Button ID="Button3" runat="server" Text="Login" OnClick="Button3_Click" />
        <p>
        
        <asp:Button ID="Button2" runat="server" Text="HomePage" OnClick="Button2_Click" style="height: 29px"/>
        <p>
        
            <asp:Button ID="Button4" runat="server" Text="Student Homepage" OnClick="Button4_Click" />
        <p>
        
            &nbsp;<p>
        <br />
    </form>
    <br />
    <br />
</body>
</html>
