/// <reference path="../jquery-1.9.1-vsdoc.js" />

$(document).ready(function () {
    var rowCount = $("#listOfUsers >tbody >tr").length;    
    $("#totalUsers").html("Esta lista contiene " + "<b>" + rowCount + "</b>" + " usuarios");
});