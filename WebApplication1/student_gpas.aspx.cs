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
    public partial class student_gpas : System.Web.UI.Page
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


            SqlCommand Viewstud = new SqlCommand("Select * from dbo.FN_StudentViewGP(@student_ID)", connection);



            Viewstud.Parameters.Add(new SqlParameter("@student_ID", id));

            connection.Open();
            using (SqlDataReader reader = Viewstud.ExecuteReader())
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
            Response.Redirect("student_access.aspx");

        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");

        }
    }
}
