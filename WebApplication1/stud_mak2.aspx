﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stud_mak2.aspx.cs" Inherits="WebApplication1.stud_mak2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter Student ID<br />
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Course ID<br />
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            Enter Current Semester<br />
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" style="height: 29px" />
        <p>
            <asp:Button ID="Button2" runat="server" Text="Student HomePage" OnClick="Button2_Click" />
        </p>
        <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
    </form>
</body>
</html>

