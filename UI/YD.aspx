<%@ Page Language="C#" AutoEventWireup="true" CodeFile="YD.aspx.cs" Inherits="YD" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>移动</title>
    <link href="CSS/YD.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="cards">
	<!--第一个-->
  <div class="card card__one">
    <div class="card__bg"></div>
    <img class="card__img" src="Images/yidong1.jpg" />
    <div class="card__text">
      <p class="card__title">干锅肥肠</p>
    </div>
  </div>
 <!-- 第二个-->
  <div class="card card__two">
    <div class="card__bg"></div>
    <img class="card__img" src="Images/yidong2.jpg" />
    <div class="card__text">
      <p class="card__title">红烧狮子头</p>
    </div>
 </div>
 <!--第三个-->
 <div class="card card__three">
    <div class="card__bg"></div>
    <img class="card__img" src="Images/yidong3.jpg" />
    <div class="card__text">
      <p class="card__title">尖椒豆腐</p>
    </div>
  </div>
  <!--第四个-->
  <div class="card card__four">
    <div class="card__bg"></div>
    <img class="card__img" src="Images/yidong4.jpg" />
    <div class="card__text">
      <p class="card__title">椒盐虾</p>
    </div>
  </div>
  <!--第五个-->
  <div class="card card__five">
    <div class="card__bg"></div>
    <img class="card__img" src="Images/yidong5.jpg" />
    <div class="card__text">
      <p class="card__title">黑醋咕噜肉</p>
    </div>
  </div>
</div>
    </form>
    <script>
var cards = document.querySelector(".cards");
var images = document.querySelectorAll(".card__img");
var backgrounds = document.querySelectorAll(".card__bg");
var range = 40;

// const calcValue = (a, b) => (((a * 100) / b) * (range / 100) -(range / 2)).toFixed(1);
var calcValue = function calcValue(a, b) { return (a / b * range - range / 2).toFixed(1); }; // thanks @alice-mx

var timeout = void 0;
document.addEventListener('mousemove', function (_ref) {
    var x = _ref.x, y = _ref.y;
    if (timeout) {
        window.cancelAnimationFrame(timeout);
    }

    timeout = window.requestAnimationFrame(function () {
        var yValue = calcValue(y, window.innerHeight);
        var xValue = calcValue(x, window.innerWidth);
        console.log(xValue, yValue);
        cards.style.transform = "rotateX(" + yValue + "deg) rotateY(" + xValue + "deg)";

        [].forEach.call(images, function (image) {
            image.style.transform = "translateX(" + -xValue + "px) translateY(" + yValue + "px)";
        });

        [].forEach.call(backgrounds, function (background) {
            background.style.backgroundPosition = xValue * .45 + "px " + -yValue * .45 + "px";
        });
    });
}, false);
</script>
</body>
</html>
