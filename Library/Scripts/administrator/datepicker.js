$(function () {
    $("#datepicker").datepicker({
        dateFormat: 'dd/mm/yy',
        changeMonth: true,
        changeYear: true,
        showAnim: 'clip',
    });

    $("#datepicker").datepicker();
    $('#iconPicker').click(function () {
        $("#datepicker").focus();
    });
});