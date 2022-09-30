// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function checkSearchForm() {
    var _in = $('#txtSearchItem').val();
    if (_in == null || _in == "") {
        alert("Arama kismi bos birakilamaz."); // buraya sweetalert yada notification gelicek.
        return false;
    }
    document.getElementById('searchForm').submit();
    return true;
}