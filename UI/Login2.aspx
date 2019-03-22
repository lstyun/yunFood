<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login2.aspx.cs" Inherits="Login2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>注册</title>
    <link href="CSS/Login2.css" rel="stylesheet" />
	<link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous"/>
    <link href="CSS/Lxy.css" rel="stylesheet" />
    <script src="JS/jquery-3.3.1.min.js"></script>
    <script src="JS/Login2.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="liuz">
		<div class="night">
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
		</div>		
		</div>
		<div id="liuy">
		<div class="night">
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
  			<div class="shooting_star"></div>
		</div>		
		</div>
		<div id="top">
			<iframe src="Top.aspx" width="100%" height="75px" frameborder="0" scrolling="no"></iframe>
		</div>
		<div id="con">
			<!--<video src="she.MP4" autoplay="autoplay" loop="loop">
			<source src="she.MP4" type="video/mp4"> 
			</video>-->
			<div id="content">
				<span id="zhspan1">
						<i><span id="yonghu" class="glyphicon glyphicon-user" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                    <asp:TextBox ID="user" runat="server" placeholder="请输入您的账号"></asp:TextBox>
				</span>
				<span id="zhspan2">
						<i><span id="yonghu" class="glyphicon glyphicon-lock" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                    <asp:TextBox ID="password" runat="server"  TextMode="Password" placeholder="密码请输入6-18位字符" ></asp:TextBox>
				</span>
				<span id="zhspan3">
						<i><span id="yonghu" class="glyphicon glyphicon-check" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                    <asp:TextBox ID="chepassword" TextMode="Password" runat="server" placeholder="确认密码"></asp:TextBox>
				</span>
				<span id="zhspan4">
						<i><span id="yonghu" class="glyphicon glyphicon-envelope" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                        <asp:TextBox ID="em" runat="server" placeholder="请输入您的邮箱"></asp:TextBox>
				</span>
				<span id="zhspan5">
						<i><span id="yonghu" class="glyphicon glyphicon-phone-alt" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                        <asp:TextBox ID="phone" runat="server" placeholder="手机号" ></asp:TextBox>
                    <asp:Button ID="huoqu" runat="server" Text="获取验证码" OnClick="huoqu_Click" />
				</span>
				<span id="zhspan6">
						<i><span id="yonghu"  class="glyphicon glyphicon-fullscreen" style="font-size: 20px;line-height:30px;color:white;text-align: center;"></span></i>
                    <asp:TextBox ID="yzm" runat="server" placeholder="验证码"></asp:TextBox>
				</span>
				<span id="zhspan7">
						<asp:Button ID="log" runat="server" Text="注册" OnClick="log_Click"  BorderStyle="None" BackColor="DeepSkyBlue" />
					</span>
			</div>
		</div>
		<div id="bottom">
			<iframe src="Bottom.aspx" width="100%" height="180px" frameborder="0" scrolling="no"></iframe>
		</div>
    </form>
</body>
</html>
