using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = "Remember Your Password is Your BIRTHDAY(in dd/mm/yyyy format)";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(TextBox1.Text);
            string password = TextBox2.Text;
            int len = password.Length;
            string pass = "";
            for(int i = 0; i < len; i++)
            {
                if (password[i] != '/')
                {
                    pass += password[i];
                }
            }
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WDDN_Project\App_Data\Database1.mdf;Integrated Security=True");
            try
            {
                using (con)
                {
                    string name = "";
                    con.Open();
                    string command = "select * from Students where Id = " + id + " and student_dob = " + pass;
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if(rdr.HasRows)
                    {
                        while (rdr.Read())
                        {
                            name = rdr["student_name"].ToString();
                        }

                        Session["student_id"] = TextBox1.Text;
                        Session["student_password"] = pass;
                        Session["studentname"] = name;
                        Response.Redirect("WebForm1.aspx");
                        
                    }
                    else
                    {
                        Label1.Text = "Invalid ID and PASSWORD";
                    }
                    //Label1.Text = Session["student_password"].ToString();
                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                Label1.Text = "error occured with " + err;
            }

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}