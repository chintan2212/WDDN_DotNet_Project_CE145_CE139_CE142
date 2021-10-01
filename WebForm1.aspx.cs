using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string student_id;
        string pass;
        string name;
        int i;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["student_id"] != null)
            {
                student_id = Session["student_id"].ToString();
                pass = Session["student_password"].ToString();
                name = Session["studentname"].ToString();
                Label2.Text = "Welcome " + name;
                i = int.Parse(student_id);
            }
            else
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Hp\source\repos\WebApplication8\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (con)
                {
                    string sem = "";
                    con.Open();
                    string command = "select * from Students where Students.Id = " + i + " and Students.student_dob = " + pass;
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        while(rdr.Read())
                        {
                          sem = rdr["student_sem"].ToString();
                        }
                    }
                    rdr.Close();
                    string command1 = "select * from " + sem + " where studentid = " + i;
                    SqlCommand cmd1 = new SqlCommand(command1, con);
                    SqlDataReader rdr1 = cmd1.ExecuteReader();


                    GridView1.DataSource = rdr1;           
                    GridView1.DataBind();
                    rdr1.Close();
                }
            }
            catch (Exception err)
            {
                Label1.Text = "error occured with " + err;
            }
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            e.Row.Cells[0].Visible = false;
            e.Row.Cells[1].Visible = false;
        }
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        
    }
}