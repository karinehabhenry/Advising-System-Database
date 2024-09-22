using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class student_access : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addPhone.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewO.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewAv.aspx");
        }


        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendC.aspx");
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("SendH.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewM.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {

        }
        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_gpas.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_inst.aspx");

        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_cou.aspx");

        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_mak1.aspx");

        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_csi.aspx");

        }

        protected void Button15_Click(object sender, EventArgs e)
        {
             Response.Redirect("stud_ics.aspx");

        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_cp.aspx");

        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_choosei.aspx");

        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            Response.Redirect("stud_mak2.aspx");

        }
    }
}