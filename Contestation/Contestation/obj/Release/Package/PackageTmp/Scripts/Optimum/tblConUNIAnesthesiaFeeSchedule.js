$(function ($) {


    $(".aAdd").colorbox({ Width: "60%", Height: "280px" });

    var $gv = $("table[id$=GridViewConUNIAnesthesiaFeeSchedule]");
    var $rows = $("> tbody > tr:not(:has(th, table))", $gv);
    var $inputs = $(".myCalCss", $rows);

    $inputs.datepicker({
        changeMonth: true,
        changeYear: true
    });


    //$("#aSearch").click(function () {
    //    $("#searchDiv").slideToggle("fast");
    //});
});

function searchDiv() {
    $("#searchDiv").slideToggle("fast");
}