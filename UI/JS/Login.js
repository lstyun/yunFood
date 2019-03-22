$(function () {
    $('#saoma').bind('click', function () {
        $('#saoma1').css('display', 'block');
        $('#zhanghao1').css('display', 'none');
    })
    $('#zhanghao').bind('click', function () {
        $('#zhanghao1').css('display', 'block');
        $('#saoma1').css('display', 'none');
    })
})
