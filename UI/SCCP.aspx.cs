using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;


using Model;

public partial class SCCP : System.Web.UI.Page
{
    public static int Foodid;
    public static int Userid;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            SXLX.DataSource = BLL.SXtypeBLL.SelectType();
            SXLX.DataBind();
            DropDownList2.DataSource = BLL.SXtypeBLL.SelectType(6);
            DropDownList2.DataValueField = "SXid";
            DropDownList2.DataTextField = "SXname";
            DropDownList2.DataBind();
            Foodid = BLL.FoodBLL.FoodID();
            //Userid= int.Parse(Session["UID"].ToString());
        }
    }
    /// <summary>
    /// 给每个下拉框绑定值
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    protected void SXLX_ItemDataBound(object sender, RepeaterItemEventArgs e)
    {         
        for (int i = 0; i < SXLX.Items.Count; i++)
        {
            DropDownList dr = (DropDownList)SXLX.Items[i].FindControl("DropDownList1");
            dr.DataSource = BLL.SXtypeBLL.SelectType(i + 1);
            dr.DataValueField = "SXid";
            dr.DataTextField = "SXname";
            dr.DataBind();
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        HttpPostedFile a = Request.Files["FileUpload1"];
        string t = DateTime.Now.ToString("mm-ss");
        a.SaveAs(Server.MapPath(".") + "/Images/" + t + ".jpg");
        HtmlInputButton[] i = { };
        i[0] = img0;
        i[0].Style["background-image"] = "url(../Images/" + t + ".jpg)";
    }
    /// <summary>
    /// 接收数据
    /// </summary>
    [WebMethod]
    public static string shangchuan(string[] zlmz, string[] zlyl, string[] flmz, string[] flyl, string[] plmz, string[] plyl,string[] bzmz,string[] bztz,int[] bzsz)
    {
        
        return "Y";
    }
   
}