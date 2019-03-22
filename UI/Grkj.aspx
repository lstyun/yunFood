<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Grkj.aspx.cs" Inherits="Grkj" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link href="CSS/Grkj.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div></div>
		<div id="z">
			<div id="zz">
				<h3>欢迎来到我的美食空间</h3>
				<div id="zzz">
					<div id="zb">
						<img src="<%= Img %>" />
					</div>
					<div id="yb">
						<h4><%= Name %>美食日志</h4>
						<span class="a">昵称:<%= Name %>&nbsp;&nbsp;&nbsp;&nbsp;|</span>
						<span class="a">性别:<%= Sex %>&nbsp;&nbsp;&nbsp;&nbsp;|</span>
						<span class="a">地址:<%= Address %>&nbsp;&nbsp;&nbsp;&nbsp;|</span>
						<span class="a"><%= Jtime %>&nbsp;&nbsp;&nbsp;&nbsp;加入Hi-yo</span>
						<p>&nbsp;&nbsp;&nbsp;<%=GRsm %></p>
					</div>
				</div>
				<p class="fl">
					<a href="#">动态</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<a href="#">作品</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<a href="#">收藏</a>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
					<a href="#">喜好</a>
				</p>
				<div id="zzzz">
					<a href="SCCP.aspx" target="_parent">发布</a>
				</div>
			</div>
		</div>
		<div></div>
    </form>
</body>
</html>
