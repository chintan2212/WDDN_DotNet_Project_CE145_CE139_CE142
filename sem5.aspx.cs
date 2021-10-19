using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class sem5 : System.Web.UI.Page
    {
        string sem = "";
        int id;
        protected void Page_Load(object sender, EventArgs e)
        {
            sem = Request.QueryString["Sem"];
            id = int.Parse(Request.QueryString["Id"]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WDDN_Project\App_Data\Database1.mdf;Integrated Security=True");

            try
            {
                using (con)
                {
                    con.Open();

                    string command_1 = "select * from " + sem + " where id = '" + id + "'";
                    SqlCommand cmd6 = new SqlCommand(command_1, con);
                    SqlDataReader rdr6 = cmd6.ExecuteReader();
                    if (rdr6.HasRows)
                    {
                        rdr6.Close();
                        string command = "update " + sem + " set WDDN = '" + TextBox2.Text + "' where studentid = '" + id + "'";
                        SqlCommand cmd = new SqlCommand(command, con);
                        SqlDataReader rdr = cmd.ExecuteReader();
                        rdr.Close();
                        string command1 = "update " + sem + " set MFP = '" + TextBox3.Text + "' where studentid = '" + id + "'";
                        SqlCommand cmd1 = new SqlCommand(command1, con);
                        SqlDataReader rdr1 = cmd1.ExecuteReader();
                        rdr1.Close();
                        string command2 = "update " + sem + " set AA = '" + TextBox1.Text + "' where studentid = '" + id + "'";
                        SqlCommand cmd2 = new SqlCommand(command2, con);
                        SqlDataReader rdr2 = cmd2.ExecuteReader();
                        rdr2.Close();
                        string command3 = "update " + sem + " set AT = '" + TextBox4.Text + "' where studentid = '" + id + "'";
                        SqlCommand cmd3 = new SqlCommand(command3, con);
                        SqlDataReader rdr3 = cmd3.ExecuteReader();
                        rdr3.Close();
                        string command4 = "update " + sem + " set OS = '" + TextBox5.Text + "' where studentid = '" + id + "'";
                        SqlCommand cmd4 = new SqlCommand(command4, con);
                        SqlDataReader rdr4 = cmd4.ExecuteReader();
                        rdr4.Close();
                        Label6.Text = "Updated";

                    }
                    else
                    {
                        rdr6.Close();
                        string command_2 = "INSERT INTO " + sem + "(studentid,AA,WDDN,MFP,AT,OS) VALUES('"+ id + "' , '" + TextBox1.Text + "', '" + TextBox2.Text + "', '" + TextBox3.Text + "', '" + TextBox4.Text + "', '" + TextBox5.Text + "')";
                        SqlCommand cmd7 = new SqlCommand(command_2, con);
                        cmd7.ExecuteNonQuery();
                       
                        Label6.Text = "Added";
                    }
                   



                }
            }
            catch (Exception ew)
            {
                Label6.Text = ew.ToString();
            }
        }
    }
}