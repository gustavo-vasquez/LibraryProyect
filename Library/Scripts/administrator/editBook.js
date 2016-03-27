$(document).ready(function () {
    $('#onlyStock').change(function () {        
        if ($('#onlyStock').is(':checked')) {            
            $('#Title').prop('disabled', true);
            $('#Author').prop('disabled', true);
            $('#Description').prop('disabled', true);
            $('#datepicker').prop('disabled', true);
            $('#Edition').prop('disabled', true);
            $('#Subject').prop('disabled', true);
        }
        else {
            $('#Title').prop('disabled', false);
            $('#Author').prop('disabled', false);
            $('#Description').prop('disabled', false);
            $('#datepicker').prop('disabled', false);
            $('#Edition').prop('disabled', false);
            $('#Subject').prop('disabled', false);
        }
    })    

    $('#modifyStock').click(function () {
        if (!$('input[name=plusOrMinus]').is(':checked')) {
            alert('Primero especifique si agrega o resta ejemplares.');
        }        
    })

    $('input[name=plusOrMinus]').on('change', function () {
        $('#modifyStock').val(0);
        $('#modifyStock').prop('readonly', false);

        if ($('input[name=plusOrMinus]:checked').val() != '-') {
            $('#modifyStock').removeAttr('max');
            
        }            
        else {
            $('#modifyStock').attr({ 'max': $('#Stock').val() });            
        }
    })

    $('#modifyStock').on('change', function () {
        if ($('input[name=plusOrMinus]:checked').val() != '+' && parseInt($('#modifyStock').val()) >= parseInt($('#Stock').val())) {
            alert('No puede quitar más ejemplares.');
        }
    })
});