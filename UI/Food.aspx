<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Food.aspx.cs" Inherits="Food" %>

<%@ Register Assembly="AspNetPager" Namespace="Wuqi.Webdiyer" TagPrefix="webdiyer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/Food.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">
			<iframe src="Top.aspx" width="100%" height="75px" frameborder="0" scrolling="no"></iframe>
		</div>
        <div id="zuo">
            <asp:Repeater ID="daoh" runat="server" OnItemCommand="daoh_ItemCommand">
                <ItemTemplate>
                        <asp:Button class="leixin" ID="BtnFoodType" runat="server" CommandName="BtnType" CommandArgument='<%#Eval("F_TypeId")%>' Text='<%# Eval("F_TypeName") %>' />
                </ItemTemplate>
        </asp:Repeater>
        </div>
        <div id="zon">
            <asp:Repeater ID="Foodz" runat="server" OnItemCommand="Foodz_ItemCommand">
                <ItemTemplate>
                    <dl class="sp">
                        <dt class="tu"><asp:Image ID="Image1" runat="server"  src='<%#Eval("photo")%>' Width="200px" Height="200px"/></dt>
                        <dd><asp:Button class="ming" ID="Label1" runat="server" Text='<%# Eval("FoodName")%>' CommandName="FoodID"  CommandArgument='<%#Eval("FoodId")%>'></asp:Button>
                            <asp:Label class="pin" ID="Label2" runat="server" Text="0评论"></asp:Label>
                            <asp:Label class="ren" ID="Label3" runat="server" Text="0人气"></asp:Label>
                        </dd>
                    </dl>
                </ItemTemplate>
        </asp:Repeater>
        </div>
         <div style="margin: 0px auto; width: 270px; font-family: 微软雅黑; font-size:21px;">
             <webdiyer:AspNetPager ID="AspNetPager1" runat="server" AlwaysShow="True" FirstPageText="首页" LastPageText="末页" NextPageText="下一页" PrevPageText="上一页" OnPageChanged="AspNetPager1_PageChanged" PageSize="9"></webdiyer:AspNetPager>
        </div>
        <div id="bottom">
			<iframe src="Bottom.aspx" width="1000px" height="75" frameborder="0" scrolling="no"></iframe>
		</div>    
    </form>
</body>
</html>
