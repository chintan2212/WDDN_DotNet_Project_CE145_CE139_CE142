using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication8
{
    public partial class Edit_marks : System.Web.UI.Page
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
                    string sem = Request.QueryString["Sem"];
                    string url;
                    url = sem + ".aspx?Id=" +
                        id + "&Sem=" +
                        sem;
                    Response.Redirect(url);
                    
                }
            }

            catch (Exception err)
            {
                Response.Write("error while connecting to database\n" + err);
            }
        }
    }
}
