using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using BLL; 


public partial class Food : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            if (Session["FoodName"] != null)
            {
                daoh.DataSource = BLL.FoodTypeBLL.selectFoodType();
                daoh.DataBind();
                int i = BLL.FoodBLL.selectFood(Session["FoodName"].ToString()).Count;
                Foodz.DataSource = BLL.FoodBLL.selectFoodIndex(1, Session["FoodName"].ToString());
                this.AspNetPager1.RecordCount = i;
                Foodz.DataBind();
                Session["FoodName"] = null;
            }
            else
            {
                daoh.DataSource = BLL.FoodTypeBLL.selectFoodType();
                daoh.DataBind();
                int i = BLL.FoodBLL.selectFood().Count;
                Foodz.DataSource = BLL.FoodBLL.selectFoodIndex(1);
                this.AspNetPager1.RecordCount = i;
                Foodz.DataBind();
            }
        }
    }

    protected void AspNetPager1_PageChanged(object sender, EventArgs e)
    {
            this.Foodz.DataSource = BLL.FoodBLL.selectFoodIndex(this.AspNetPager1.CurrentPageIndex);
            this.Foodz.DataBind();
    }

    protected void daoh_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "BtnType")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            //string TtpeName=((Button)e.Item.FindControl("BtnFoodType")).Text;
            int i = BLL.FoodBLL.selectFood(id).Count;
            Foodz.DataSource = BLL.FoodBLL.selectFoodIndex(1,id);
            this.AspNetPager1.RecordCount = i;
            Foodz.DataBind();
        }
    }//给类型按钮绑定事件

    protected void Foodz_ItemCommand(object source, RepeaterCommandEventArgs e)//给每个图片绑定事件
    {
        if (e.CommandName == "FoodID")
        {
            int id = int.Parse(e.CommandArgument.ToString());//获取点击的食品的ID
            Session["FoodID"] = id;//利用Session储存传到详细页面
            Response.Redirect("xiangxi.aspx");
        }
    }
}