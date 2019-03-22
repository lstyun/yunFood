<%@ Page Language="C#" AutoEventWireup="true" CodeFile="xiangxi.aspx.cs" Inherits="xiangxi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="CSS/xiangxi.css" rel="stylesheet" />
    <script src="JS/jquery-3.3.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div id="top">
			<iframe src="Top.aspx" width="100%" height="75px" frameborder="0" scrolling="no"></iframe>
		</div>
        <div id="zon">
            <div id="zuo">
            <asp:Image ID="tu"  runat="server" />
             </div>
            <div id="you">
                <asp:Label ID="Name" runat="server" Text=""></asp:Label>
                <div id="shuxin">
                    <div id="sx1">
                        <asp:Label class="biao" ID="gy" runat="server" Text="工艺"></asp:Label>
                        <asp:Label ID="gy1" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div id="sx2">
                        <asp:Label ID="nd" runat="server" Text="难度"></asp:Label>
                        <asp:Label ID="dn1" runat="server" Text="Label"></asp:Label>
                    </div>
                    <div id="sx3">
                         <asp:Label ID="rs" runat="server" Text="人数"></asp:Label>
                         <asp:Label ID="rs1" runat="server" Text=""></asp:Label>
                    </div>
                    <div id="sx4">
                        <asp:Label ID="kw" runat="server" Text="口味"></asp:Label>
                        <asp:Label ID="kw1" runat="server" Text=""></asp:Label>
                    </div>
                    <div id="sx5">
                        <asp:Label ID="ZBtime" runat="server" Text="准备时间"></asp:Label>
                        <asp:Label ID="ZBtime1" runat="server" Text=""></asp:Label>
                    </div>
                    <div id="sx6">
                        <asp:Label ID="PRtime" runat="server" Text="烹饪时间"></asp:Label>
                        <asp:Label ID="PRtime1" runat="server" Text=""></asp:Label>
                    </div>
                </div>
            </div>
        </div>     
        <div id="cailiao">
            <asp:Label ID="Fjs" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="yongliao" runat="server" Text="用料"></asp:Label>
            <%if(BLL.FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 1)!=null)
                             {%>
            <div id="ZL">
                <asp:Label ID="zhuliao" runat="server" Text="主料"></asp:Label>
            <asp:Repeater ID="FoodZL" runat="server">
                <ItemTemplate>
                    <asp:Image ID="FZLT" runat="server" src='<%#Eval("FoodCLT")%>' Width="30px" Height="30px" />
                    <a href="#"><%#Eval("FoodCLM")%></a>
                    <asp:Label ID="FZLS" runat="server" Text='<%#Eval("FoodCLS")%>'></asp:Label>
                </ItemTemplate>
            </asp:Repeater>
            </div>
            <%} %>
            <%if(BLL.FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 2)!=null)
                             {%>
            <div id="FL">
             <asp:Label ID="fuliao" runat="server" Text="辅料"></asp:Label>
             <asp:Repeater ID="FoodFL" runat="server">
                <ItemTemplate>
                    <asp:Image ID="FFLT" runat="server"  src='<%#Eval("FoodCLT")%>' Width="30px" Height="30px" />
                    <a href="#"><%#Eval("FoodCLM")%></a>
                    <asp:Label ID="FFLS" runat="server" Text='<%#Eval("FoodCLS")%>'></asp:Label>
                </ItemTemplate>
            </asp:Repeater>
             </div>
            <%} %>
            <%if(BLL.FoodCLBLL.selectFoodCL(int.Parse(Session["FoodID"].ToString()), 3)!=null)
                             {%>
            <div id="TL">
              <asp:Label ID="tiaoliao" runat="server" Text="调料"></asp:Label>
              <asp:Repeater ID="FoodTL" runat="server">
                <ItemTemplate>
                    <asp:Image ID="FTLT" runat="server"  src='<%#Eval("FoodCLT")%>' Width="30px" Height="30px" />
                    <a href="#"><%#Eval("FoodCLM")%></a>
                    <asp:Label ID="FTLS" runat="server" Text='<%#Eval("FoodCLS")%>'></asp:Label>
                </ItemTemplate>
            </asp:Repeater> 
            <%} %>
            </div>
        </div>
        <div id="zuofa">
            <asp:Repeater ID="FoodZF" runat="server" OnItemDataBound="FoodZF_ItemDataBound">
                <ItemTemplate>
                    <div id="zuofa1">
                    <asp:Label ID="ZFS" runat="server" Text='<%#Eval("FoodSU")%>'></asp:Label>
                    <asp:Label ID="ZFM" runat="server" Text='<%#Eval("FoodZFM")%>'></asp:Label>
                    <asp:Image ID="ZFT" runat="server"  src='<%#Eval("FoodZFT")%>' />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
        <div id="pinglun">
            <asp:Repeater ID="PL" runat="server" OnItemDataBound="PL_ItemDataBound" OnItemCommand="PL_ItemCommand">
                <ItemTemplate>
                    <div class="pinglun1">
                        <div class="pinglun2">
                            <div class="DT">
                            <asp:Label ID="xuhao" runat="server" Text='<%#Eval("PLId")%>' Visible="False"></asp:Label>
                            <asp:ImageButton ID="touxiang" CssClass="TXD" runat="server" src='<%#Eval("Img")%>'/>
                            </div>
                            <div class="Con"><a href="#">
                                <%#Eval("Name")%></a> :
                                <asp:Label ID="PLleinong" runat="server" Text='<%#Eval("Review")%>'></asp:Label><br/>
                                <asp:Label  CssClass="shijianZ" ID="PLleinongSJZ" runat="server" Text='<%#DateTime.Parse(Eval("PingTime").ToString()).ToString("MM月dd日 HH:mm") %>'></asp:Label>
                                <img src="Images/回复.png" id="HFZ" class="HFZ" />
                            </div>     
                        </div>
                            <asp:TextBox ID="TextBox1" class="ZPL" placeholder="评论" text="" runat="server"></asp:TextBox>
                            <asp:Button ID="Button1"  class="ZPLBT" runat="server" Text="回复" CommandName="BtnType" CommandArgument='<%#Eval("PLId")%>' />
                        <div class="pinglun3">
                        <asp:Repeater ID="HUF" runat="server" OnItemCommand="HUF_ItemCommand">
                            <ItemTemplate>
                                    <asp:Image ID="IM1" src='<%#Eval("HImg")%>' runat="server" Class="TX"/>
                                   <a href="#"><%#Eval("HName")%></a>
                                     回复
                                    <asp:Image ID="IM2" src='<%#Eval("FImg")%>' runat="server" Class="TX"/>
                                    <a href="#"><%#Eval("FName")%></a>：
                                    <%#Eval("Content")%>
                                <div class="DHF">
                                 <asp:Label ID="PLleinongSJ"  CssClass="shijian" runat="server" Text='<%#DateTime.Parse(Eval("SJ").ToString()).ToString("MM月dd日 HH:mm") %>'></asp:Label>
                                 <img src="Images/回复.png" id="HF" class="HF" />
                                </div>
                                <asp:Label ID="xuhao" runat="server" Text='<%#Eval("ZID")%>' Visible="False"></asp:Label>
                                <asp:TextBox ID="TextBox2" class="PL" placeholder="评论" text="" runat="server"></asp:TextBox>
                                <asp:Button ID="Button2"  class="PLBT" runat="server" Text="回复"  CommandName="BtnType2" CommandArgument='<%#Eval("Hid")%>' /><br />
                            </ItemTemplate>
                        </asp:Repeater>
                          </div>
                    </div>
                </ItemTemplate>
            </asp:Repeater>
            <asp:TextBox class="HFPL" ID="zfu"  runat="server" placeholder="评论" text=""></asp:TextBox>
            <asp:Button ID="FB" CssClass="FB" runat="server" Text="发布" OnClick="FB_Click" />
        </div>
    </form>
    <script type="text/javascript">
        $(function () {
            $(".ZPL").hide();
            $(".ZPLBT").hide();
            $(".PL").hide();
            $(".PLBT").hide();
            $(".HFPL").focus(function () {
                $(this).removeClass("HFPL").addClass("HFPL1");
                $("#FB").removeClass("FB").addClass("FBX");
                $(".PL").hide();
                $(".PLBT").hide();
                $(".ZPL").hide();
                $(".ZPLBT").hide();
            }) 
            $(".shijian").mouseover(function () {
                $(this).next().removeClass("HF").addClass("HF1");
            })
            $(".shijian").next().mouseout(function () {
                $(this).removeClass("HF1").addClass("HF");
            })
            $(".shijianZ").mouseover(function () {
                 $(this).next().removeClass("HFZ").addClass("HFZ1");
            })
            $(".shijianZ").next().mouseout(function () {
                $(this).removeClass("HFZ1").addClass("HFZ");
            })
            $(".HFZ").click(function () {
                $(".ZPL").hide();
                $(".ZPLBT").hide();
                $(".PL").hide();
                $(".PLBT").hide()
                $("#zfu").removeClass("HFPL1").addClass("HFPL");
                $("#FB").removeClass("FBX").addClass("FB"); 
                $(this).parent().parent().next().show();
                $(this).parent().parent().next().next().show();
            })
            $(".HF").click(function () {
                $(".ZPL").hide();
                $(".ZPLBT").hide();
                $(".PL").hide();
                $(".PLBT").hide()
                $("#zfu").removeClass("HFPL1").addClass("HFPL");
                $("#FB").removeClass("FBX").addClass("FB"); 
                $(this).parent().next().show();
                $(this).parent().next().next().show();
            })
        })
    </script>
</body>
</html>