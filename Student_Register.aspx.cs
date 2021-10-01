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
    public partial class Student_Register : System.Web.UI.Page
    {
        //string student_id;
        //string pass;
        //string name;
        //int i;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["student_id"] != null)
            //{
            //    student_id = Session["student_id"].ToString();
            //    pass = Session["student_password"].ToString();
            //    name = Session["studentname"].ToString();
            //    i = int.Parse(student_id);
            //}
            //else
            //{
            //    Response.Redirect("LoginPage.aspx");
            //}
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\itzch\source\repos\WebApplication8\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (con)
                {

                    con.Open();
                    string command = "INSERT INTO Students (student_name,student_dob,student_sem,student_email,student_city,student_state,student_gender,student_category,student_mobile) VALUES( '" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "','" + TextBox7.Text + "','" + TextBox8.Text + "','" + TextBox9.Text + "')";
                    SqlCommand cmd = new SqlCommand(command, con);
                    //cmd.Parameters.AddWithValue("@student_name", TextBox1.Text);
                    //cmd.Parameters.AddWithValue("@student_dob", TextBox2.Text);
                    //cmd.Parameters.AddWithValue("@student_sem", TextBox3.Text);
                    //cmd.Parameters.AddWithValue("@student_email", TextBox4.Text);
                    //cmd.Parameters.AddWithValue("@studnet_city", TextBox5.Text);
                    //cmd.Parameters.AddWithValue("@student_state", TextBox6.Text);
                    //cmd.Parameters.AddWithValue("@student_gender", TextBox7.Text);
                    //cmd.Parameters.AddWithValue("@student_category", TextBox8.Text);
                    //cmd.Parameters.AddWithValue("@student_mobile", TextBox9.Text);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception err)
            {
                //Label1.Text = "error occured with " + err;
            }
        }
    }
}