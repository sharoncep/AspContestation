$(function ($) {

    $(".aAdd").colorbox({ Width: "60%", Height: "260px" });

    var $gv = $("table[id$=GridViewContFrdmCapitatedProviders]");
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
