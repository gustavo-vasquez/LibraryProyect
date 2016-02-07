/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function() {
    // Check if body height is higher than window height :)
    if ($("body").height() > $(window).height()) {        
        $("#goTop").show();
    }
    else {
        $("#goTop").hide();
    }
});