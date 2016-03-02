$(document).ready(function () {

    $('#empForm').removeData('validator').removeData('unobtrusiveValidation');
    $.validator.unobtrusive.parse('#empForm');

    $('#Antique').on('input', function () {
        var calcSalary = $("#Antique").val() * 6500;
        if (calcSalary != 0) {
            $("#Salary").val(calcSalary);
        }
        else
            $("#Salary").val(6500);
    });

    $('#CaptchaTextbox').keyup(function () {
        $('#CaptchaTextbox').val($('#CaptchaTextbox').val().toUpperCase());
    });
});