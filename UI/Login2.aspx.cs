using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using Model;//引用Model层
using System.Text.RegularExpressions;//引用正则表达式
using System.Security.Cryptography.X509Certificates;
using System.Net;
using System.IO;
using System.Text;
using System.Net.Security;

public partial class Login2 : System.Web.UI.Page
{
    private const String host = "https://cxkjsms.market.alicloudapi.com";
    private const String path = "/chuangxinsms/dxjk";
    private const String method = "POST";
    private const String appcode = "da17486c3c2a4c5f98e1cec1a6055c21";

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void log_Click(object sender, EventArgs e)
    {
        if (this.password.Text == this.chepassword.Text)
        {
            User u = new User();
            u.Email= this.em.Text;
            u.Phone= int.Parse(this.phone.Text);
            if (this.yzm.Text == Session["suiji"].ToString())
            {
                if (BLL.LoginBLL.InsertLogin(this.user.Text,this.password.Text,u))
                {
                    Response.Write("<script>alert('注册成功')</script>");
                }
                else
                {
                    Response.Write("<script>alert('注册失败')</script>");
                }
            }
            else
            {
                Response.Write("<script>alert('验证码错误')</script>");
            }
        }
        else
        {
            Response.Write("<script>alert('两次密码不一致')</script>");
        }
    }


    protected void huoqu_Click(object sender, EventArgs e)
    {

        //string dianxin = @"^1[3578][01379]\d{8}$";//电信手机号
        //string liantong = @"^1[34578][01256]\d{8}$";//联通手机号      
        //string yidong = @"^(134[012345678]\d{7}|1[34578][012356789]\d{8})$";//移动手机号
        //Regex rx = new Regex(@"^0{0,1}(13[4-9]|15[7-9]|15[0-2]|18[7-8])[0-9]{8}$");
        //Regex yReg = new Regex(yidong);
        //Regex tReg = new Regex(liantong);
        //Regex dReg = new Regex(dianxin);
        //if (this.phone.Text != null && (rx.IsMatch(this.phone.Text) || dReg.IsMatch(this.phone.Text) || tReg.IsMatch(this.phone.Text) || yReg.IsMatch(this.phone.Text)))
        //{
        //    Random rd = new Random();//生成随机数
        //    Session["suiji"]=rd.Next(1000, 9999);
        //    ClientScript.RegisterStartupScript(this.GetType(), "message", "<script type='text/javascript'>codeButton();</script>");
        //    String querys = "content=【创信】你的验证码是："+Session["suiji"] +"，3分钟内有效！&mobile="+this.phone.Text+"";
        //    String bodys = "";
        //    String url = host + path;
        //    HttpWebRequest httpRequest = null;
        //    HttpWebResponse httpResponse = null;

        //    if (0 < querys.Length)
        //    {
        //        url = url + "?" + querys;
        //    }

        //    if (host.Contains("https://"))
        //    {
        //        ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(CheckValidationResult);
        //        httpRequest = (HttpWebRequest)WebRequest.CreateDefault(new Uri(url));
        //    }
        //    else
        //    {
        //        httpRequest = (HttpWebRequest)WebRequest.Create(url);
        //    }
        //    httpRequest.Method = method;
        //    httpRequest.Headers.Add("Authorization", "APPCODE " + appcode);
        //    if (0 < bodys.Length)
        //    {
        //        byte[] data = Encoding.UTF8.GetBytes(bodys);
        //        using (Stream stream = httpRequest.GetRequestStream())
        //        {
        //            stream.Write(data, 0, data.Length);
        //        }
        //    }
        //    try
        //    {
        //        httpResponse = (HttpWebResponse)httpRequest.GetResponse();
        //    }
        //    catch (WebException ex)
        //    {
        //        httpResponse = (HttpWebResponse)ex.Response;
        //    }

        //    Console.WriteLine(httpResponse.StatusCode);
        //    Console.WriteLine(httpResponse.Method);
        //    Console.WriteLine(httpResponse.Headers);
        //    Stream st = httpResponse.GetResponseStream();
        //    StreamReader reader = new StreamReader(st, Encoding.GetEncoding("utf-8"));
        //    Console.WriteLine(reader.ReadToEnd());
        //    Console.WriteLine("\n");
        //}
        //else
        //{
        //    Response.Write("<script>alert('手机号码不正确')</script>");
        //}

    }
    public static bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
    {
        return true;
    }
}