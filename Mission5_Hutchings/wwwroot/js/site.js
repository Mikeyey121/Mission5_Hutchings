// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

// Function that will calculate the users quote based on my rate
$("#btnSubmit").click(function () {
    alert("Rate = " + $("#rate").val() + "\nHour(s) = " + 
    $("#hours").val() + "\nTotal quote = $" + parseInt($("#hours").val())*10 + ".00")
})