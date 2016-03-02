$(document).ready(function () {

    $('#adminForm').removeData('validator').removeData('unobtrusiveValidation');
    $.validator.unobtrusive.parse('#adminForm');
    
    $('#nameGroup').on('change', function () {
        //var optionSelected = $("option:selected", this);
        //var valueSelected = this.value;
        var optionSelected = $(this).find("option:selected");
        var valueSelected = optionSelected.val();

        switch (valueSelected) {
            case 'Liga federal': $("#Salary").val(6500); break;
            case 'Megacity': $("#Salary").val(9000); break;
            case 'Ley de la selva': $("#Salary").val(16500); break;
            default: $("#Salary").val(0); break;
        }
    });

    $('#CaptchaTextbox').keyup(function () {
        $('#CaptchaTextbox').val($('#CaptchaTextbox').val().toUpperCase());
    });
});