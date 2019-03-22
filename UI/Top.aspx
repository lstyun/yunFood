<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Top.aspx.cs" Inherits="Top" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/Top.css" rel="stylesheet" />
    <script src="js/jquery-3.3.1.min.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
		<div id="top"> 
                <iframe id="tianqi" scrolling="no" src="https://tianqiapi.com/api.php?style=tm&skin=pitaya" frameborder="0"  width="270" height="50"  allowtransparency="true"></iframe>
			<img src="Images/logo3.png"/ id="logo" />
			<div class="dh1">
				<a href="Index.aspx" target="_parent" >首页</a>
			</div>
			<div class="dh2">
				<a href="Food.aspx" target="_parent">吃货天堂</a>
			</div>
			<div class="dh3">
				<a href="Snacks-xiangcai .html" target="_parent">吃货菜谱</a>
			</div>
			<div class="dh4">
				<a href="#">手机下载</a>
			</div>
            <asp:TextBox ID="sou" runat="server" placeholder="请输入内容"></asp:TextBox>
            <asp:Button ID="suo" runat="server" Text="搜索" OnClick="Suo_Click" />          
            <% if (Model.Login.UserL != 1)
                {
            %> <a href="Login.aspx" runat="server" target="_parent" id="denglu" >快速登陆</a>
			   <a href="Login2.aspx"  runat="server" target="_parent" id="zhuce" >快速注册</a>
            <%
                }
            else if(Model.Login.UserL == 1)  
                { 
             %>
                <asp:ImageButton runat="server" ID="TX" OnClick="TX_Click"  ></asp:ImageButton>
            <%
            }
               %>           
            </div>
    </form>
</body>
</html>
