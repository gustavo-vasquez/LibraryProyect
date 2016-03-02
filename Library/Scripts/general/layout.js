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

    $("#loginForm").on('invalid-form.validate', function (form, validator) {
        var errors = "Error de login:\n";

        for (var i = 0; i < validator.errorList.length; i++) {
            errors = errors + "\r\n\u2794 " + validator.errorList[i].message;
        }

        alert(errors + "\r\n");
    });

});