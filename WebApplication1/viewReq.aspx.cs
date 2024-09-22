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
    public partial class viewReq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);



            if (!Int32.TryParse(TextBox1.Text, out int id))
            {
                Response.Write("Please enter the ID in form of integer");
                return;
            }
            string sem = TextBox2.Text;
            SqlCommand ViewO = new SqlCommand("Procedures_ViewRequiredCourses", connection);

            ViewO.CommandType = System.Data.CommandType.StoredProcedure;
            ViewO.Parameters.Add(new SqlParameter("@StudentID", id));
            ViewO.Parameters.Add(new SqlParameter("@current_semester_code", sem));
            int userName = (int)Session["user"];
            if (id == userName)
            {
                connection.Open();
                using (SqlDataReader reader = ViewO.ExecuteReader())
                {
                    string html = "<table border='1'><tr>";

                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        html += "<th>" + reader.GetName(i) + "</th>";
                    }

                    html += "</tr>";

                    while (reader.Read())
                    {
                        html += "<tr>";

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            html += "<td>" + reader[i] + "</td>";
                        }

                        html += "</tr>";
                    }

                    html += "</table>";

                    Literal1.Text = html;
                }
                connection.Close();
            }
            else
                Response.Write("Enter Your Id");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("student_access.aspx");
        }
    }
}