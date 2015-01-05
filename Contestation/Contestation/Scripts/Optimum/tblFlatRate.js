$(document).ready(function ($) {

    $(".aAdd").colorbox({ width: "60%", height: "250px" });

    $("#aSearch").click(function () {
        $("#searchDiv").slideToggle("fast");
    });
});

function slideDiv() {
    $("#searchDiv").slideToggle("fast");
}

function showColorbox() {
    var text = $("#colorboxhtml").html();
    $.colorbox({ html: text });
}