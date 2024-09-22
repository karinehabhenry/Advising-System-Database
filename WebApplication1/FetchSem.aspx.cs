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
    public partial class FetchSem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);



            SqlCommand Semster_offered_Courses = new SqlCommand("select*from  Semster_offered_Courses", connection);


            connection.Open();
            using (SqlDataReader reader = Semster_offered_Courses.ExecuteReader())
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



        protected void Button2_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");

        }
    }

}