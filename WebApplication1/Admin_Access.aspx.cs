using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Admin_Access : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("List_Students_with_Advisors.aspx");

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("ListAllAdvisors.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("PendingReq.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSem.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCourse.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkICS.aspx");


        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkSA.aspx");

        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("LinkCI.aspx");

        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewIC.aspx");

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("FetchSem.aspx");

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddMakeupExam.aspx");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteSlot.aspx");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteCourse.aspx");
        }

        protected void Button15_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminViewingPayment.aspx");
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminIssuingInstallment.aspx");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudentStatus.aspx");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("FetchDetailsOfActiveStudents.aspx");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewGPWithAdvisors.aspx");
        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewStudentsTranscriptDetails.aspx");
        }
    }
}