$(document).ready(function () {

    var animation = $("#loading").html();

    $("#slctUser").change(function () {
        switch ($("#slctUser option:selected").val()) {        

            case '1': $("#types").removeClass("hide");
                      $("#types").html(animation);
                      $("#types").load("/User/Student");                       
                      break;

            case '2': $("#types").removeClass("hide");
                      $("#types").html(animation);
                      $("#types").load("/User/Employee");
                      break;

            case '3': $("#types").removeClass("hide");
                      $("#types").html(animation);
                      $("#types").load("/User/Administrator");
                      break;

            default: $("#types").addClass("hide");
                     $("#types").unload();
                     break;
        }
    });
});

function redirectToHome() {
    document.body.innerHTML = '';
    window.location.replace("/Home/Index");
}