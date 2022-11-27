using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Assignment5.Guest
{
    public partial class UserReg : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            object ob = db.Executescalar("insert into Login values('" + txtuname.Text + "','" + txtpswd.Text + "','block','user');select @@IDENTITY");
            db.dbclose();
            if (ob.ToString() != null)
            {
                int i = db.Executenonquery("insert into Employee values('" + txtname.Text + "','" + txtmail.Text + "','" + txtage.Text + "'," + ob + ")");
                db.dbclose();
                if (i == 1)
                {
                    Response.Write("<script>alert('User Registered Successfully');</script>");
                }
                else
                {
                    Response.Write("<script>alert('Failed');</script>");
                }
            }
        }
    }
}