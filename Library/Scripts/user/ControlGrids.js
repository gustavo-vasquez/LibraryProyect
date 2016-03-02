$(document).ready(function () {
    var rowCount = $("#listOfUsers >tbody >tr").length;    
    $("#totalUsers").html("Esta lista contiene " + "<b>" + rowCount + "</b>" + " usuarios");
});