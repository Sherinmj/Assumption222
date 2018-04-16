using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ChurchWebPortal
{
    public partial class view_studentsParishMemb : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                grid();
            }
        }


        public void getcon()
        {
            con.ConnectionString = ConfigurationManager.ConnectionStrings["Assumption"].ConnectionString;
            con.Open();
        }
        public void grid()
        {
            getcon();
            string str = "select * from student_details";
            SqlCommand cmd = new SqlCommand(str, con);
            cmd.ExecuteNonQuery();
            SqlDataAdapter adr = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }
    }
}