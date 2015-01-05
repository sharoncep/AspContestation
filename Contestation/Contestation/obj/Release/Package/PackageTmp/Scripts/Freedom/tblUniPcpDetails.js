$(function ($) {

    $(".aAdd").colorbox({ width: "60%", height: "380px" });

    var $gv = $("table[id$=GridViewUniPcpDetails]");
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
