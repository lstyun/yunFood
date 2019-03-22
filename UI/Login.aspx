<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>登陆</title>
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap@3.3.7/dist/css/bootstrap.min.css"/>
    <link href="CSS/Lxy.css" rel="stylesheet" />
    <link href="CSS/Login.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
    <script src="js/Login.js" type="text/javascript"></script>
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
		<div id="zhong">
			<video src="MV/she.MP4" autoplay="autoplay" loop="loop">
			<source src="MV/she.MP4" type="video/mp4" /> 
			</video>
			<div id="content">
				<span id="saoma">	
					<a href="#"><i style="text-shadow: black 6px 3px 3px;color:dodgerblue;">扫码登陆</i></a>
				</span>
				<span id="zhanghao">
					<a href="#"><i style="color: white;">账号登陆</i></a>
				</span>
				<div id="saoma1">
					<img src="http://qr.topscan.com/api.php?text=滴滴"id="erwei"/>
					<br />
					<span id="saoma2">
						请使用手机扫码登陆
					</span>
					<div id="saoma3">
						<a href="#">使用帮助</a><span id="shu">
							|
						</span><a href="#">下载客户端</a>
					</div>
				</div>
				<div id="zhanghao1">
					<span id="zhspan1">
						<i><span id="yonghu" class="glyphicon glyphicon-user" style="font-size: 28px;line-height:45px;color: white;text-align: center;"></span></i>
						<input type="text" runat="server" name="user" id="user" placeholder="请输入账号或者手机号" />
					</span>
					<span id="zhspan2">
						<i><span id="mima" class="glyphicon glyphicon-lock" style="font-size: 28px;line-height:45px;color: white;text-align: center;"></span></i>
                        <input type="password" runat="server" name="password" id="password" />
					</span>
					<a id="zuche" href="Login2.aspx">立即注册</a>
					<a id="wanji" href="#">忘记密码?</a>
					<span id="zhspan3">
						<asp:Button ID="log" runat="server" Text="登陆" OnClick="Log_Click"  BorderStyle="None" BackColor="DeepSkyBlue" />
					</span>
				</div>	
			</div>
		</div>
		<div id="bottom">
			<iframe src="Bottom.aspx" width="100%" height="180px" frameborder="0" scrolling="no"></iframe>
		</div>
    </form>
</body>
</html>
