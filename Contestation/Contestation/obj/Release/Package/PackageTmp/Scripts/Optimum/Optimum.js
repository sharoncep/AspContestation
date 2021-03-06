﻿$(document).ready(function () {

    var id = getQueryVariable("id");
    setStyle(id);

    $('.tooltip1').tooltipster({
        contentAsHTML: true
    });

    $("#ContentPlaceHolder1_txtFrom").datepicker({
        changeMonth: true,
        changeYear: true,
        onSelect: function (selectedDate) {
            $("#ContentPlaceHolder1_txtTo").datepicker("option", "minDate", selectedDate);
        }
    });

    $("#ContentPlaceHolder1_txtFrom").datepicker("option", "showAnim", "show");

    $("#ContentPlaceHolder1_txtTo").datepicker({
        changeMonth: true,
        changeYear: true,
        onSelect: function (selected) {
            $("#ContentPlaceHolder1_txtFrom").datepicker("option", "maxDate", selected)
        }
    });

    $("#ContentPlaceHolder1_txtTo").datepicker("option", "showAnim", "show");


    //for Check all check boxes
    $('[id^="ContentPlaceHolder1_rptrDataList_chkSelect_"]').on('change blur', function () {
        $('#ContentPlaceHolder1_rptrDataList_chkAll').prop('checked', !($('[id^="ContentPlaceHolder1_rptrDataList_chkSelect_"]').not(':checked').length));
    });
    $('#ContentPlaceHolder1_rptrDataList_chkAll').on('change blur', function () {
        $('[id^="ContentPlaceHolder1_rptrDataList_chkSelect_"]').prop('checked', $(this).prop('checked'));
    });
    $('[id^="ContentPlaceHolder1_rptrDataList_chkSelect_"]').eq(0).blur();


});

function dropCounty() {
    $("#ContentPlaceHolder1_drpPcpCounty").change(function () {
        //Remove items from ContentPlaceHolder1_drpPcpName
        $("#ContentPlaceHolder1_drpPcpName option").remove();

        $.ajax({
            type: "POST",
            url: "../Freedom/Freedom.aspx/getPcpNames",
            data: '{pcpCounty: "' + $("#ContentPlaceHolder1_drpPcpCounty").val() + '", claimType: "' + $("input:radio[name='ctl00$ContentPlaceHolder1$rbtnlstClaimType']:checked").val() + '" }',
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data.d == null) {

                    //$('#ContentPlaceHolder1_drpPcpName').css('display', 'none');
                    //$('#ContentPlaceHolder1_lblPcpName').css('display', 'none');
                    //$('#divList').css('display', 'none');

                    $('#ContentPlaceHolder1_drpPcpName').hide();
                    $('#ContentPlaceHolder1_lblPcpName').hide();
                    $('#divList').hide();
                }
                else {

                    //$('#ContentPlaceHolder1_drpPcpName').css('display', 'block');
                    //$('#ContentPlaceHolder1_lblPcpName').css('display', 'block');
                    ////$('#divList').css('display', 'block');

                    $('#ContentPlaceHolder1_drpPcpName').show();
                    $('#ContentPlaceHolder1_lblPcpName').show();
                    //$('#divList').css('display', 'block');

                    $('#ContentPlaceHolder1_drpPcpName').append($("<option></option>").attr("value", 0).text("--Select--"));

                    for (i in data.d) {
                        var d = data.d[i];
                        $('#ContentPlaceHolder1_drpPcpName').append($("<option></option>").attr("value", d.pcpID).text(d.pcpName));
                    }
                }
            },
            failure: function (response) {
                alert(response.d);
            }
        });
    });
}

function dropNames() {

    $("#ContentPlaceHolder1_drpPcpName").change(function () {

        var selItem = $('#ContentPlaceHolder1_drpPcpName').find(":selected").text();
        if (selItem == "--Select--") {
            $('#divList').css('display', 'none');
        }
        else {
            $('#divList').css('display', 'block');
        }

    });
}


function uncheck() {
    // if all checkbox are selected, check the selectall checkbox
    // and viceversa
    if (!$(this)[0].checked) {
        $("#ContentPlaceHolder1_rptrDataList_chkAll").attr("checked", false);
    }
}

function ShowDetails(pky, PCP_ID, PCP_NAME, MEMBER_ID, MEMBER_NAME, CLAIM_TYPE, CLAIM_ID, BILL_POS, SERVICE_CODE, FROM_DATE, TO_DATE, CHECK_DATE, SERVICE_CODE_MODI, LINE_NO, UNITS, DRG_CODE, PROVIDER_ID, PROVIDER_NAME, TOTAL_CHARGE, PAID_AMOUNT, REASON) {
    var tblData;
    tblData = "";
    tblData = tblData + "<table class=\"table-list\">";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td width=\"20%\">Pcp ID</td>";
    tblData = tblData + "<td width=\"30%\">";
    tblData = tblData + PCP_ID;
    tblData = tblData + "</td>";
    tblData = tblData + "<td width=\"20%\">Pcp Name</td>";
    tblData = tblData + "<td width=\"30%\">";
    tblData = tblData + PCP_NAME;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Member Id</td>";
    tblData = tblData + "<td>";
    tblData = tblData + MEMBER_ID;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Member Name</td>";
    tblData = tblData + "<td>";
    tblData = tblData + MEMBER_NAME;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";
    tblData = tblData + "<tr>";

    tblData = tblData + "<td>Claim Type</td>";
    tblData = tblData + "<td>";
    tblData = tblData + CLAIM_TYPE;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Claim Id</td>";
    tblData = tblData + "<td>";
    tblData = tblData + CLAIM_ID;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";
    tblData = tblData + "<tr>";

    tblData = tblData + "<td>Bill Type Pos</td>";
    tblData = tblData + "<td>";
    tblData = tblData + BILL_POS;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Service Code</td>";
    tblData = tblData + "<td>";
    tblData = tblData + SERVICE_CODE;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>From Date</td>";
    tblData = tblData + "<td>";
    tblData = tblData + FROM_DATE;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>To Date</td>";
    tblData = tblData + "<td>";
    tblData = tblData + TO_DATE;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Check Date</td>";
    tblData = tblData + "<td>";
    tblData = tblData + CHECK_DATE;
    tblData = tblData + "</td>";
    tblData = tblData + "<td></td>";
    tblData = tblData + "<td>";
    //tblData = tblData + TO_DATE;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Service code Modifier</td>";
    tblData = tblData + "<td>";
    tblData = tblData + SERVICE_CODE_MODI;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Line No</td>";
    tblData = tblData + "<td>";
    tblData = tblData + LINE_NO;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Units</td>";
    tblData = tblData + "<td>";
    tblData = tblData + UNITS;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Drg Code</td>";
    tblData = tblData + "<td>";
    tblData = tblData + DRG_CODE;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Provider Id</td>";
    tblData = tblData + "<td>";
    tblData = tblData + PROVIDER_ID;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Provider Name</td>";
    tblData = tblData + "<td>";
    tblData = tblData + PROVIDER_NAME;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Total Charges</td>";
    tblData = tblData + "<td>";
    tblData = tblData + TOTAL_CHARGE;
    tblData = tblData + "</td>";
    tblData = tblData + "<td>Paid Amount</td>";
    tblData = tblData + "<td>";
    tblData = tblData + PAID_AMOUNT;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "<tr>";
    tblData = tblData + "<td>Reason</td>";
    tblData = tblData + "<td>";
    tblData = tblData + REASON;
    tblData = tblData + "</td>";
    tblData = tblData + "<td></td>";
    tblData = tblData + "<td>";
    //tblData = tblData + DATE_OF_CONTEST;
    tblData = tblData + "</td>";
    tblData = tblData + "</tr>";

    tblData = tblData + "</table>";
    $.colorbox({ html: tblData, closeButton: true, width: "70%" });

    //$("#dialog-form_" + pky).html(tblData);
    //$("#dv-blanket").fadeIn();
    //$('#dialog-form_' + pky).toggle();
    //$("#dialog-form_" + pky).dialog({
    //    autoOpen: false,
    //    height: 415,
    //    width: 1020,
    //    modal: true
    //});

    //$("#dialog-form_" + pky).dialog("open");

}

function saveChecked() {
    var Row = document.getElementById("somerow");
    var Cells = Row.getElementsByTagName("td");
    alert(Cells[0].innerText);

}

function ValidateRecords() {

    var count = $('input[type=checkbox]').filter(':checked').length;

    if (count <= 0) {
        alert("Nothing to save !");

        return false;
    }
    else {
        return true;
    }
}

function ValidateEntry() {
    var fromChk = checkDate($("#ContentPlaceHolder1_txtFrom").val());
    var toChk = checkDate($("#ContentPlaceHolder1_txtTo").val());

    if (!fromChk) {
        alert("From date is not in correct format");
        return false;
    }
    if (!toChk) {
        alert("To date is not in correct format");
        return false;
    }
    if ($("#ContentPlaceHolder1_txtFrom").val() == "" || $("#ContentPlaceHolder1_txtTo").val() == "") {
        alert("Please select from date and to date");
        return false;
    }
    else if ($("#ContentPlaceHolder1_drpPcpCounty").val() == "--Select--") {
        alert("Please select pcp county");
        return false;
    }
    else if ($("#ContentPlaceHolder1_drpPcpName").val() == "--Select--" || $("#ContentPlaceHolder1_drpPcpName").val() == "") {
        alert("Please select pcp name");
        return false;
    }
    else {
        return true;
    }
}

function checkDate(dVal) {
    try {
        $.datepicker.parseDate('m/d/yy', dVal, null);
    }
    catch (error) {
        return false;
    }
    return true;
}

function setStyle(caseNo) {

    for (var i = 1; i <= 11; i++) {
        $("#ContentPlaceHolder1_LinkButton" + i).removeClass('cases-active');
    }

    $("#ContentPlaceHolder1_LinkButton" + caseNo).addClass('cases-active');
    //alert(caseNo);
}

function getQueryVariable(variable) {
    var query = window.location.search.substring(1);
    var vars = query.split("&");
    for (var i = 0; i < vars.length; i++) {
        var pair = vars[i].split("=");
        if (pair[0] == variable) { return pair[1]; }
    }
    return (false);
}

