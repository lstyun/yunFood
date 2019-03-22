function codeButton() {
    var code = $("#huoqu");
    code.attr("disabled", "disabled");
    var time = 60;
    var set = setInterval(function () {
        code.val("" + --time + "秒后重新获取");
    }, 1000);
    setTimeout(function () {
        code.attr("disabled", false).val("获取验证码");
        clearInterval(set);
    }, 60000);
}
