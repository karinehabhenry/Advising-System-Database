using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Student_Registration1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void register(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);

            string FirstName = fn.Text;
            string LastName = ln.Text;
            string Password = ps.Text;
            string Mail = mail.Text;
            string Major = maj.Text;
            string Faculty = fac.Text;
            if (!Int32.TryParse(sem.Text, out int Semester))
            {
                Response.Write("Please enter the semester in form of integer");
                return;
            }
            

            SqlCommand StuReg = new SqlCommand("Procedures_StudentRegistration", connection);
            StuReg.CommandType = System.Data.CommandType.StoredProcedure;

            StuReg.Parameters.Add(new SqlParameter("@first_name", FirstName));
            StuReg.Parameters.Add(new SqlParameter("@last_name", LastName));
            StuReg.Parameters.Add(new SqlParameter("@password", Password));
            StuReg.Parameters.Add(new SqlParameter("email", Mail));
            StuReg.Parameters.Add(new SqlParameter("@major", Major));
            StuReg.Parameters.Add(new SqlParameter("@faculty", Faculty));
            StuReg.Parameters.Add(new SqlParameter("@Semester", Semester));

            SqlParameter reg = StuReg.Parameters.Add("@Student_id", SqlDbType.Int);
            reg.Direction = ParameterDirection.Output;
            
            connection.Open();
            StuReg.ExecuteNonQuery();  
            int studentId = Convert.ToInt32(reg.Value);
            connection.Close();
            Response.Write("Your ID is  ");
            Response.Write(studentId);
            Response.Write("    Please Go To Login Page");
            connection.Close();
           
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Studentlogin.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }
    }
}