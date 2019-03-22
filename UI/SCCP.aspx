<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SCCP.aspx.cs" Inherits="SCCP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <script src="JS/jquery-3.3.1.js"></script>
    <script src="JS/SCCP.js"></script>
    <link href="CSS/SCCP.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="cp">
			<div id="fbu">
				<div id="f1">
					<p>欢迎发布新菜谱，先介绍一下你的大作！</p>
				</div>
				<div id="f2">
					<div>
						<ul>
							<li>标题</li>
							<li class="chak">
								<a href="#">查看帮助>>></a>
							</li>
						</ul>
                        <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                        <asp:TextBox ID="FoodN"  placeholder="请填写菜谱名称，十字以内" style="width: 198px;height: 27px;" runat="server"></asp:TextBox>
					</div>

					<div id="shux">
                        <asp:Repeater ID="SXLX" runat="server" OnItemDataBound="SXLX_ItemDataBound">
                            <HeaderTemplate>
                                <p class="s1">属性</p>
                            </HeaderTemplate>
                            <ItemTemplate>
                                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                            </ItemTemplate>
                            <FooterTemplate>
                                <p class="s2">成品图</p>
                            </FooterTemplate>
                        </asp:Repeater>
					</div>
					<ul>
						<li><input id="img0" type="button" runat="server" onclick="FileUpload1.click()" />
                            <input type="file" runat="server" id="FileUpload1" class="sc" onchange="$('#Button2').click()" />
                            <asp:Button ID="Button2" runat="server" Text="Button" Class="sc" OnClick="Button2_Click" />
						</li>
						<li><input type="text" placeholder="说说当时的心情吧！" style="width: 280px;height: 25px;"/>
						</li>
					</ul>
				</div>
			</div>
			<div id="cl">
				<div id="c1">
					<p>记录所有原材料</p>
				</div>
				<div id="c2">
                  <div id="tj1">
                  	<p>主料</p>
                  	<p> <input id="IZL" class="Ins" type="button"/></p>
                  </div>
                  <div id="tj2">
                  	<p>辅料</p>
                  	<p><input id="IZF" class="Ins" type="button"/></p>
                  </div>
                  <div id="tj3">
                      <p>配料</p>
                      <p><input id="IZP" class="Ins" type="button"/></p>
                  </div>
				</div>
			</div>
			<div id="buz">
                <input id="Ins" class="Ins" type="button" />
			</div>
            <input id="sc" type="button" value="上传" />
		</div>
    </form>
     <script type="text/javascript">
         $(function () {
             var q = 1;
             var z = 1;
             var f = 1;
             var p = 1;
             var zlm = []; var zls = [];
             var flm = []; var fls = [];
             var plm = []; var pls = [];
             var bzm = []; var bzt = []; var bzs = [];
            $("#Ins").bind('click', function () {

                var i = '<div class="buzou"><label class="bzsl" id="la'+q+'">'+q+'</label><input calss="bzml" type="text" placeholder="随便写点东西吧" /><br/><input calss="bzt" id="img'+q+'" class="bz"  type="button" onclick="FileUpload1.click()" /></div>';
                $(i).insertBefore($(this));
                q++;
             })
            $("#IZL").bind('click', function () {

                var i = ' <div class="zl"><input class="zll" id="ZLM'+z+'" type="text" placeholder="请填写主料名称""/><input class="zyll" id="ZLS'+z+'" type="text" placeholder="请填写用量""/><input id="shanchu'+z+'" class="shan" type="button" "/></div>';
                 $(i).insertBefore($(this));
                 $("#shanchu"+z).bind('click',function(){ $(this).parent().remove();}) 
                z++;
             })
            $("#IZF").bind('click', function () {

                var i = ' <div class="fl"><input class="fll" id="FLM'+f+'" type="text" placeholder="请填写辅料名称""/><input class="fyll" id="FLS'+f+'" type="text" placeholder="请填写用量""/><input id="shanchu'+f+'" class="shan" type="button"/></div>';
                 $(i).insertBefore($(this));
                 $("#shanchu"+f).bind('click',function(){ $(this).parent().remove();}) 
                f++;
             }) 
            $("#IZP").bind('click', function () {

                var i = ' <div class="fl"><input  class="pll" id="PLM'+p+'" type="text" placeholder="请填写配料名称""/><input class="pyll" id="PLS'+p+'" type="text" placeholder="请填写用量""/><input id="shanchu'+p+'" class="shan" type="button"/></div>';
                 $(i).insertBefore($(this));
                 $("#shanchu"+p).bind('click',function(){ $(this).parent().remove();}) 
                p++;
             })
            $("#sc").bind('click', function () {
                var zyl = document.getElementsByClassName('zll');
                var zyll = document.getElementsByClassName('zyll');
                var fyl = document.getElementsByClassName('fll');
                var fyll = document.getElementsByClassName('fyll');
                var pyl = document.getElementsByClassName('pll');
                var pyll = document.getElementsByClassName('pyll');
                var bzsl = document.getElementsByClassName('bzsl');
                var bzml = document.getElementsByClassName('bzml');
                var bztl=document.getElementsByClassName('bztl');
                for (var i = 0; i < zyl.length; i++) {
                    //zlm.push(zyl[i].value);
                    zlm[i] = zyl[i].value;
                 }
                for (var i = 0; i < zyll.length; i++) {
                    //zls.push(zyll[i].value);
                    zls[i] = zyl[i].value;
                }
                for (var i = 0; i < fyl.length; i++) {
                    //flm.push(fyl[i].value);
                    flm[i] = fyl[i].value;
                 }
                for (var i = 0; i < fyll.length; i++) {
                    //fls.push(fyll[i].value);
                    fls[i] = fyll[i].value;
                }
                for (var i = 0; i < pyl.length; i++) {
                    //plm.push(pyl[i].value);
                    plm[i] = pyl[i].value;
                 }
                for (var i = 0; i < pyll.length; i++) {
                    //pls.push(pyll[i].value);
                    pls[i] = pyll[i].value;
                }
                for (var i = 0; i < bzsl.length; i++) {
                    //bzs.push(bzsl[i].value);
                    bzs[i] = bzsl[i].value;
                }
                for (var i = 0; i < bzml.length; i++) {
                    //bzm.push(bzml[i].value);
                    bzm[i] = bzml[i].value;
                }
                for (var i = 0; i < bztl.length; i++) {
                    //bzt.push(bztl[i].value);
                    bzt[i] = bztl[i].value;
                }
                $.ajax({
                    url:"SCCP.aspx/shangchuan",
                    type: 'POST',
                    dataType: "json",
                    contentType: "application/json;charset=utf-8",
                    async: true,
                    data: JSON.stringify({ zlmz: zlm, zlyl: zls, flmz: flm, flyl: fls, plmz: plm, plyl: pls, bzsz: bzs, bzmz: bzm,bztz:bzt }),
                    success: function (data) { alert(data.d); },
                    error: function () {
                    alert("error");
                }
                })
            })
         })
    </script>
</body>
</html>


