$(document).ready(function () {
    $('#btnselectImg').click(function () {
        var finder = new CKFinder();
        finder.selectActionFunction = function (fileUrl) {
            $('#txtImg').val(fileUrl);
        };
        finder.popup();
    });
});