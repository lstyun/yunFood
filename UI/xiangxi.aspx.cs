using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Model;
using BLL;

public partial class xiangxi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Food Fod = FoodBLL.Food(int.Parse(Session["FoodID"].ToString()));
            shuxing SX = shuxingBLL.selectSX(int.Parse(Session["FoodID"].ToString()));
            tu.ImageUrl = Fod.Photo;
            Name.Text = Fod.FoodName;
            gy1.Text = SX.Process;
            dn1.Text = SX.Difficulty;
            rs1.Text = SX.N_Pren.ToString();
            kw1.Text = SX.Taste;
            ZBtime1.Text = SX.ZBtime;
            PRtime1.Text = SX.PRtime;
            Fjs.Text = Fod.FoodJs ;
            FoodZL.DataSource = FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 1);
            FoodZL.DataBind();
            FoodFL.DataSource =FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 2);
            FoodFL.DataBind();
            FoodTL.DataSource= FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 3);
            FoodTL.DataBind();
            FoodZF.DataSource = FoodZFBLL.selectFoodZF(int.Parse(Session["FoodID"].ToString()));
            FoodZF.DataBind();
            PL.DataSource =PinglunBLL.SelectpinglunBLL(int.Parse(Session["FoodID"].ToString()));
            PL.DataBind();
        }
    }
    /// <summary>
    /// 嵌套绑定数据
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void PL_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {
        if (e.Item.ItemIndex >= 0)
        {
            Label la = (Label)e.Item.FindControl("xuhao");
            Repeater re = (Repeater)e.Item.FindControl("HUF");
            re.DataSource = BLL.PinglunBLL.SelectpinglunBLL(int.Parse(Session["FoodID"].ToString()), int.Parse(la.Text));
            re.DataBind();
        }
    }
    protected void FoodZF_ItemDataBound(object sender, RepeaterItemEventArgs e)//判断图片是否为空 如为空不显示
    {
        //if (e.Item.ItemIndex >= 0)
        //{
        //    Image img = (Image)e.Item.FindControl("ZFT");
        //    if (img.ImageUrl == null || img.ImageUrl == "")
        //    {
        //        img.Visible = false;
        //    }
        //}
    }
    /// <summary>
    /// 发布评论
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void FB_Click(object sender, EventArgs e)
    {
        if (Model.Login.UserL != 1)
        {
            Response.Write("<script>alert('您还没有登陆')</script>");
            return;
        }
        pinglun p = new pinglun();
        p.FoodId = int.Parse(Session["FoodID"].ToString());
        p.UserId = int.Parse(Session["UID"].ToString());
        p.Review = zfu.Text;
        p.PingTime = DateTime.Now;
        if (BLL.PinglunBLL.Insertpinglun(p))
        {
            PL.DataSource = PinglunBLL.SelectpinglunBLL(int.Parse(Session["FoodID"].ToString()));
            PL.DataBind();
            zfu.Text = "";
        }

    }
    /// <summary>
    /// 给回复一级评论进行绑定事件
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void PL_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "BtnType")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            pinglun p = new pinglun();
            p.SId = id;
            p.zId = id;
            p.FoodId = int.Parse(Session["FoodID"].ToString());
            if (Model.Login.UserL != 1)
            {
                Response.Write("<script>alert('您还没有登陆')</script>");
                return;
            }
            p.UserId = int.Parse(Session["UID"].ToString());
            p.Review =((TextBox)e.Item.FindControl("TextBox1")).Text;
            p.PingTime = DateTime.Now;
            if (BLL.PinglunBLL.InsertpinglunH(p))
            {
                PL.DataSource = PinglunBLL.SelectpinglunBLL(int.Parse(Session["FoodID"].ToString()));
                PL.DataBind();
            }
        }
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="source"></param>
    /// <param name="e"></param>
    protected void HUF_ItemCommand(object source, RepeaterCommandEventArgs e)
    {
        if (e.CommandName == "BtnType2")
        {
            int id = int.Parse(e.CommandArgument.ToString());
            pinglun p = new pinglun();
            p.SId = id;
            p.zId = int.Parse(((Label)e.Item.FindControl("xuhao")).Text);
            p.FoodId = int.Parse(Session["FoodID"].ToString());
            if (Model.Login.UserL != 1)
            {
                Response.Write("<script>alert('您还没有登陆')</script>");
                return;
            }
            p.UserId = int.Parse(Session["UID"].ToString());
            p.Review = ((TextBox)e.Item.FindControl("TextBox2")).Text;
            p.PingTime = DateTime.Now;
            if (BLL.PinglunBLL.InsertpinglunH(p))
            {
                PL.DataSource = PinglunBLL.SelectpinglunBLL(int.Parse(Session["FoodID"].ToString()));
                PL.DataBind();
            }
        }
    }
}