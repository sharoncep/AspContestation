$(function ($) {

    $(".aAdd").colorbox({ width: "60%" });

    var $gv = $("table[id$=GridViewTblMVA_FRH]");
    var $rows = $("> tbody > tr:not(:has(th, table))", $gv);
    var $inputs = $(".myCalCss", $rows);

    $inputs.datepicker({
        changeMonth: true,
        changeYear: true
    });


});

function searchDiv() {
    $("#searchDiv").slideToggle("fast");
}
