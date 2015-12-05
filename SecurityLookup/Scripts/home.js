$(function () {
    document.getElementById('symbol').focus();
});

function lookupSecurity() {
    var symbolString = document.getElementById('symbol').value;
    var searchTextString = document.getElementById('searchText').value;
    var ajaxParameters = {
        url: "/Home/GetSecurityTable",
        type: "GET",
        data: { symbol: symbolString, searchText: searchTextString },
        cache: false,
        success: lookupSecuritySuccess,
        error: lookupSecurityError
    }

    $.ajax(ajaxParameters);
}

function lookupSecuritySuccess(data) {
    $("#securityTableContainer").html(data);
}

function lookupSecurityError(xhr, status, error) {
    alert(error);
}
