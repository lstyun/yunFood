using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL;
using Model;

public partial class Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Log_Click(object sender, EventArgs e)
    {
        string uid = this.user.Value;
        string pwd = this.password.Value;
        if (uid != null && pwd != null)
        {
            if (BLL.LoginBLL.SelectLogin(uid, pwd).Rows.Count>0)
            {
                Response.Write("<script>alert('登陆成功')</script>");
                Model.Login.UserL = 1;
                Session["UID"] = BLL.LoginBLL.SelectLogin(uid, pwd).Rows[0][0].ToString();
                Response.Redirect("Index.aspx");
            }
            else
            {
                Response.Write("<script>alert('登陆失败')</script>");
                Model.Login.UserL = 0;
            }
        }
        else
        {
            return;
        }

    }
}