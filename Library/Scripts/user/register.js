/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function () {
    var animation = $("#loading").html();

    $("#slctUser").change(function () {
        switch ($("#slctUser option:selected").val()) {        

            case '1': $("#formStudent").removeClass("hide");
                      $("#formStudent").html(animation);
                      $("#formStudent").load("/User/Student").fadeIn();            
                      break;

            case '2': alert(2);
                break;

            case '3': alert(3);
                break;

            default: $("#formStudent").addClass("hide");
                     $("#formStudent").unload();
        }
    });   
});

function redirectToHome() {
    document.body.innerHTML = '';
    window.location.replace("/Home/Index");
}