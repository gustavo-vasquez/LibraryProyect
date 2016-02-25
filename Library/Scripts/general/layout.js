/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function () {

    $(window).scroll(function () {
        if ($(this).scrollTop() > 100) {
            $('#goTop').fadeIn();
        } else {
            $('#goTop').fadeOut();
        }
    });

    $('#goTop').click(function () {
        $("html, body").animate({ scrollTop: 0 }, 600);
        return false;
    });
});