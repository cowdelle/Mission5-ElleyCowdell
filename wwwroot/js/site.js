
$(document).ready(function () {
    $("#calculateBtn").click(function () {
        var hours = parseFloat($("#hours").val());
        if (isNaN(hours) || hours <= 0) {
            alert("Please enter a valid positive number for hours.");
            return;
        }

        $.ajax({
            url: '@Url.Action("CalculateTotal", "Tutoring")',
            type: 'POST',
            data: { hours: hours },
            success: function (data) {
                $("#total").val("$" + data.toFixed(2));
            },
            error: function () {
                alert("An error occurred while processing your request.");
            }
        });
    });
});