<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="List_Students_with_Advisors.aspx.cs" Inherits="WebApplication1.List_Students_with_Advisors1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
               <asp:Literal ID="Literal1" runat="server"></asp:Literal>

               <br />
               <br />
               List All Students with Their Advisors<br />
               <br />
               <asp:Button ID="Button1" runat="server" Text="Display" OnClick="Button1_Click" />

               <br />
               <br />
               <asp:Button ID="Button2" runat="server" Text="Admin Homepage" OnClick="Button2_Click1" />
               <br />
               <br />
               <asp:Button ID="Button3" runat="server" Text="Homepage" OnClick="Button3_Click1" />

        </div>
    </form>
</body>
</html>
