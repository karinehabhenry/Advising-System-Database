﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="stud_csi.aspx.cs" Inherits="WebApplication1.stud_csi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="View" OnClick="Button1_Click" />
                        <asp:Literal ID="Literal1" runat="server"></asp:Literal>

        </div>
        <p>
            <asp:Button ID="Button2" runat="server" Text="Student HomePage" OnClick="Button2_Click" />
        </p>
        <p>
            <asp:Button ID="Button3" runat="server" Text="HomePage" OnClick="Button3_Click" />
        </p>
    </form>
</body>
</html>
