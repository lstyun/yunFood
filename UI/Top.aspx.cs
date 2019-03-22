using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Model;
using System.Data;
using BLL;

public partial class Top : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Model.Login.UserL == 1)
        {
            User u=BLL.LoginBLL.selectUser(int.Parse(Session["UID"].ToString()));
            TX.ImageUrl = u.Img;
        }
        else
        {

        }
    }

    protected void Suo_Click(object sender, EventArgs e)//储存搜索值然后跳转
    {
        if (sou.Text.Trim() != null)
        {
            Session["FoodName"] = sou.Text;//利用Session储存
            Response.Redirect("Food.aspx");
        }
    }

    protected void TX_Click(object sender, ImageClickEventArgs e)//跳转个人空间
    {
        Response.Redirect("Grkj.aspx");
    }
}