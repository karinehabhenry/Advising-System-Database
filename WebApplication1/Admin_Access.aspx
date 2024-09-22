<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Admin_Access.aspx.cs" Inherits="WebApplication1.Admin_Access" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Button ID="Button11" runat="server" Text="List All Students with Corresponding Advisors" OnClick="Button11_Click" />  &nbsp;<br />
        <br />
        <asp:Button ID="Button2" runat="server" Text="List All Advisors" OnClick="Button2_Click" />
        <p>
            &nbsp;<asp:Button ID="Button3" runat="server" Text="List All pending Requests" OnClick="Button3_Click" />  &nbsp;</p>
            <asp:Button ID="Button4" runat="server" Text="Add New Semester" OnClick="Button4_Click" />
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Text="Add New Course" OnClick="Button5_Click" />             &nbsp;<br />
        <br />
&nbsp;<asp:Button ID="Button6" runat="server" Text="Link Instructor to Course (specific Slot)" OnClick="Button6_Click" />
        <p>
            <asp:Button ID="Button8" runat="server" Text="Link Student to Advisor" OnClick="Button8_Click" />            &nbsp;</p>
        <p>
            &nbsp;<asp:Button ID="Button7" runat="server" Text="Link Course to Instructor" OnClick="Button7_Click" />            &nbsp;
        </p>
        <p>
            <asp:Button ID="Button10" runat="server" Text="View All Instructors with their assigned courses" OnClick="Button10_Click" />            &nbsp;</p>
        <p>
            &nbsp;<asp:Button ID="Button9" runat="server" Text="Fetch All Semesters with offered courses" OnClick="Button9_Click" />            &nbsp;
        </p>
        <p>
            <asp:Button ID="Button12" runat="server" Text="Delete a course" OnClick="Button12_Click" />
        </p>
        <p>
            <asp:Button ID="Button13" runat="server" OnClick="Button13_Click" Text="Delete a Slot" />
        </p>
        <p>
            <asp:Button ID="Button14" runat="server" OnClick="Button14_Click" Text="Add Makeup Exam" />
        </p>
        <p>
            <asp:Button ID="Button15" runat="server" Text="View payment details" OnClick="Button15_Click" />
        </p>
        <p>
            <asp:Button ID="Button16" runat="server" Text="Issue installments" OnClick="Button16_Click" />
        </p>
        <asp:Button ID="Button17" runat="server" Text="update student status" OnClick="Button17_Click" />
        <p>
            <asp:Button ID="Button18" runat="server" Text="Fetch details of active students" OnClick="Button18_Click" />
        </p>
        <asp:Button ID="Button19" runat="server" Text="view graduation plan" OnClick="Button19_Click" />
        <p>
            <asp:Button ID="Button20" runat="server" Text="View All Students transcript details" OnClick="Button20_Click" />
        </p>
    </form>
</body>
</html>
