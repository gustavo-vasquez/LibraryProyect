/// <reference path="../jquery-1.9.1-vsdoc.js" />

function selectItem() {    
    switch ($("#slctUser option:selected").val()) {
        case '0': $("#formFields").addClass("hide");
            break;

        case '1': $("#formFields").removeClass("hide");
            $("#divCareer").removeClass("hide");
            $("#divCondition").removeClass("hide");
            $("#divAntique").addClass("hide");
            $("#divPolitic").addClass("hide");
            break;

        case '2': $("#formFields").show();
            $("#divCareer").addClass("hide");
            $("#divCondition").addClass("hide");
            $("#divAntique").removeClass("hide");
            $("#divPolitic").addClass("hide");
            break;

        case '3': $("#formFields").removeClass("hide");
            $("#divCareer").addClass("hide");
            $("#divCondition").addClass("hide");
            $("#divAntique").addClass("hide");
            $("#divPolitic").removeClass("hide");
            break;
    }
}