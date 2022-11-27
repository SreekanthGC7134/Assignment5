using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Assignment5.Admin
{
    public partial class Admin1 : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridView1.DataSource = db.Executedataset("select * from Employee e inner join Login l on e.Loginid=l.Loginid");
                GridView1.DataBind();

                GridView2.DataSource = db.Executedataset("select * from Employee e inner join Login l on e.Loginid=l.Loginid");
                GridView2.DataBind();
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update Login set status='Confirm' where Loginid='" + id + "'");

            GridView1.DataSource = db.Executedataset("select * from Employee e inner join Login l on e.Loginid=l.Loginid");
            GridView1.DataBind();


        }

        protected void GridView2_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView2.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update Login set status='Blocked' where Loginid='" + id + "'");

            GridView2.DataSource = db.Executedataset("select * from Employee e inner join Login l on e.Loginid=l.Loginid");
            GridView2.DataBind();
        }
    }
}