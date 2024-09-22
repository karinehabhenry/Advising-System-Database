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
    public partial class ViewStudentsTranscriptDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["Advising_System"].ToString();
            SqlConnection connection = new SqlConnection(connString);



            SqlCommand Students_Courses_transcript = new SqlCommand("select*from  Students_Courses_transcript", connection);


            connection.Open();
            using (SqlDataReader reader = Students_Courses_transcript.ExecuteReader())
            {
                string html = "<table border='1'><tr>";

                // Display column headers
                for (int i = 0; i < reader.FieldCount; i++)
                {
                    html += "<th>" + reader.GetName(i) + "</th>";
                }

                html += "</tr>";

                // Display data rows
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Access.aspx");
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
    }
    }
