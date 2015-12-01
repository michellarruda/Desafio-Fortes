$(document).ready(function () {
    $('.date-input')
        .datepicker({
            format: 'dd/mm/yyyy',
            startDate: '01/01/2010',
            endDate: '12/30/2020',
            language: "pt-BR",
            orientation: "top right",
            autoclose: true,
            ignoreReadonly: true
        });
  
});

