<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>主页</title>
    <link href="CSS/Index.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
	<script src="js/Index.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">
			<iframe src="Top.aspx" width="100%" height="75px" frameborder="0"  scrolling="no"></iframe>
		</div>
		 	 <div class="cont">
                  <div id="shu1">|</div>
		 		<div id="sp">
		 			美食视频
		 		</div>		 	<div class="video">
		 		<div id="left"></div>
		 			<div>
		 				<ul>
		 					<li class="video1"><div><video  preload="none"><source src="MV/2.mp4"/></video><h3></h3></div></li>
		 					<li class="video2"><div><video preload="none"><source src="MV/6.mp4"/></video><h3></h3></div></li>
							<li class="video3"><div><video  preload="none"><source src="MV/3.mp4"/></video><h3></h3></div></li>
							<li class="video4"><div><video  preload="none"><source src="MV/4.mp4"/></video><h3></h3></div></li>
							<li class="video5"><div><video  preload="none"><source src="MV/5.mp4"/></video><h3></h3></div></li>
		 				</ul>
		 			</div>
		 		<div id="right"></div>
		 	</div>
		 </div>

		 	<div id="zhuda">
		 		<span id="jinrezuda">今日主打</span>
		 		<div id="yidong">
		 		<iframe src="YD.aspx" width="1000px" height="500px" frameborder="0" scrolling="no"></iframe>
		 		</div>
		 	</div>
		 	<div id="remen">
		 		<div id="shu">|</div>
		 		<div id="remenhd">
		 			热门活动
		 		</div>
		 		<div id="zhenzaijinxin">
		 			<a href="#">官方活动</a>
		 		</div>
		 		<div id="cqhd">
		 			<a href="#">合作活动</a>
		 		</div>
		 		<ul id="hd1">
		 			<a href="#" class="cq"><li>
		 				<img src="Images/2.jpg" class="img"/>
		 				<p>水滴筹</p>
		 				<span class="changqi">
		 					长期活动
		 				</span>
		 			</li></a>
		 			<a href="#" class="cq"><li><img src="Images/2.jpg" class="img"/><p>美食锦鲤</p>
		 				<span class="changqi">
		 					长期活动
		 				</span></li></a>
		 			<a href="#" class="cq"><li><img src="Images/2.jpg" class="img"/><p>随处可见美食</p>
		 				<span class="changqi">
		 					长期活动
		 				</span></li></a>
		 			<a href="#" class="cq"><li><img src="Images/2.jpg" class="img"/><p>水滴筹</p>
		 				<span class="changqi">
		 					长期活动
		 				</span></li></a>
		 		</ul>
		 	</div>
		<div id="bottom">
			<iframe src="Bottom.aspx" width="100%" height="180px" frameborder="0" scrolling="no"></iframe>
		</div>
    </form>
</body>
</html>
