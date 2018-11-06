$(document).ready(function () {
    $("[class*=Button]").button();
    $("[class*=Date]").datepicker({
        dateFormat: 'dd/mm/yy'
    });

    $("[id*=numberK").spinner();
})