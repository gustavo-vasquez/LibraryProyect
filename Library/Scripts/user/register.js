/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function () {
    $("#slctUser").change(function () {
        switch ($("#slctUser option:selected").val()) {        

            case '1': $("#formStudent").removeClass("hide");                  
                      $("#formStudent").load("/User/Student");                
                      break;

            case '2': alert(2);
                break;

            case '3': alert(3);
                break;

            default: $("#formStudent").addClass("hide");
        }
    });   
});