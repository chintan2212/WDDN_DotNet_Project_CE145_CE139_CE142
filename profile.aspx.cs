using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication8
{
    public partial class profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WDDN_Project\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (con)
                {
                    string id = Request.QueryString["Id"];
                    string name = Request.QueryString["Name"];
                    con.Open();
                    string command = "select * from Students where Id = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        Label1.Text = rdr["student_name"].ToString();
                        Label2.Text = rdr["student_dob"].ToString();
                        Label3.Text = rdr["student_sem"].ToString();
                        Label4.Text = rdr["student_email"].ToString();
                        Label5.Text = rdr["student_city"].ToString();
                        Label6.Text = rdr["student_state"].ToString();
                        Label7.Text = rdr["student_gender"].ToString();
                        Label8.Text = rdr["student_category"].ToString();
                        Label9.Text = rdr["student_mobile"].ToString();
                    }
                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                Response.Write("error while connecting to database\n" + err);
            }
        }
    }
}