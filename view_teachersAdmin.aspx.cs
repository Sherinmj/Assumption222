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
    public partial class view_teachersAdmin : System.Web.UI.Page
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
            string str = "select * from teacher_details";
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
        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            getcon();
            String id = ((Label)GridView1.Rows[e.RowIndex].FindControl("label2")).Text;
            string del = "delete from teacher_details where teacher_id=" + id;
            SqlCommand cmd = new SqlCommand(del, con);
            cmd.ExecuteNonQuery();
            con.Close();
            grid();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            grid();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            getcon();
            String teacher_id = ((Label)GridView1.Rows[e.RowIndex].FindControl("label2")).Text;
            String teacher_name = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox1")).Text;
            String std = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox2")).Text;
            String noofstudent = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox3")).Text;
            String joining_date = ((TextBox)GridView1.Rows[e.RowIndex].FindControl("TextBox4")).Text;


            String update = "update teacher_details set teacher_name='" + teacher_name + "', std='" + std + "',noofstudent='" + noofstudent + "',joining_date='" +joining_date  + "'where teacher_id='" + teacher_id + "'";
            SqlCommand cmd = new SqlCommand(update, con);
            cmd.ExecuteNonQuery();
            con.Close();
            GridView1.EditIndex = -1;
            grid();

        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            grid();
        }
    }
}