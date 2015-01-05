$(document).ready(function () {

    //$('#dialog-form').toggle();

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
});

function getData() {

    var chkData = $('#ContentPlaceHolder1_rbtnSearch input:checked').val()

    var fromDate = $("#ContentPlaceHolder1_txtFrom").val();
    var toDate = $("#ContentPlaceHolder1_txtTo").val();

    if (chkData == "all") {
        return true;
    }

    else if (chkData == "date") {


        if (fromDate.length > 0 && toDate.length > 0) {
            return true;
        }
        else {
            alert("Please select from date and to date !");
        }
    }
    else {
        alert("Please select a search criteria");
    }

    return false;
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

    //$('#dialog-form_' + pky).toggle();
    //$("#dialog-form_" + pky).dialog({
    //    autoOpen: false,
    //    height: 415,
    //    width: 1020,
    //    modal: true
    //});

    //$("#dialog-form_" + pky).dialog("open");

}

