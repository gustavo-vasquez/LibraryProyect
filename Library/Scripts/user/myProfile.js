/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function () {

$("#chkPassword").click(function () {
    if ($("#chkPassword").is(':checked')) {
        $('#inputPassword').prop("disabled", false);
        $('#inputNewPassword').prop("disabled", false);
        $('#inputRePassword').prop("disabled", false);
    }
    else {
        $('#inputPassword').prop("disabled", true);
        $('#inputNewPassword').prop("disabled", true);
        $('#inputRePassword').prop("disabled", true);
    }
});

});