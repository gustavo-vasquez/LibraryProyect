$("#idMonths").change(function () {
    if ($("#idYears option:selected").val() != "" && $("#idMonths option:selected").val() != "") {
        var lastDay = daysInMonth($("#idMonths option:selected").val(), $("#idYears option:selected").val());
        $('#idDays').find("option:not(:first)").remove();

        for (i = 1; i <= lastDay; i++) {
            $("#idDays").append($("<option value=" + i + ">" + i + "</option>"));
        }
    }
});

$("#idYears").change(function () {
    if ($("#idMonths option:selected").val() == "2") {
        var lastDay = daysInMonth($("#idMonths option:selected").val(), $("#idYears option:selected").val());

        if (lastDay == 29) {
            $("#idDays").append($("<option value=" + lastDay + ">" + lastDay + "</option>"));
        }
        else if ($('#idDays').find("option:last").val() == 29) {
            $('#idDays').find("option:last").remove();
        }
    }
});

function daysInMonth(month, year) {
    return new Date(year, month, 0).getDate();
}

//July
//daysInMonth(7,2009); //31

//February
//daysInMonth(2,2009); //28
//daysInMonth(2,2008); //29