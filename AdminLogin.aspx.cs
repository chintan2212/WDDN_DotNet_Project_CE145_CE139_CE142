using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AdminLogin : System.Web.UI.Page
    {
        string user="";
        string pass = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WDDN_Project\App_Data\Database1.mdf;Integrated Security=True");

            try
            {
                using (con)
                {
                    user=TextBox1.Text;
                    pass = TextBox2.Text;
                    con.Open();
                    string command = "select * from AdminTable where AdminTable.username = '" + user + "' and AdminTable.password = '" + pass +"'";
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.HasRows)
                    {
                        Response.Redirect("AdminPage.aspx");
                    }
                    else
                    {
                        Label1.Text = "Admin Not found";
                    }
                    //GridView1.DataSource = rdr;
                    //GridView1.DataBind();
                    rdr.Close();
                    
                    
                }
            }
            catch (Exception err)
            {
                Label1.Text = err.ToString();
           
            }
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}