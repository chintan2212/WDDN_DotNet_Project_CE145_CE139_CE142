using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class AdminPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\WDDN_Project\App_Data\Database1.mdf;Integrated Security=True");

            try
            {
                using (con)
                {
                    con.Open();
                
                    string command = "select * from " + DropDownList1.SelectedValue.ToString();
                    SqlCommand cmd = new SqlCommand(command, con);
                    SqlDataReader rdr = cmd.ExecuteReader();
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();


                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                Label1.Text = "error occured with " + err;

            }
        }
    }
}