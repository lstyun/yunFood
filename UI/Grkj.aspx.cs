using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Model;

public partial class Grkj : System.Web.UI.Page
{
    public string Name;
    public string Img;
    public string Sex;
    public string Address;
    public DateTime Jtime;
    public string GRsm;
    protected void Page_Load(object sender, EventArgs e)
    {
        User u = BLL.LoginBLL.selectUser(int.Parse(Session["UID"].ToString()));
        Name = u.Name;
        Img = u.Img;
        Sex = u.Sex;
        Address=u.Address;
        Jtime = u.Jtime;
        GRsm = u.GRsm;
    }
}