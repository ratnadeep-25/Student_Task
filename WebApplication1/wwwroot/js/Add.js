$(document).ready(function () {
    // Save button click event
    console.log("add.js script is running.");
    $("#saveButton").on("click", function () {
        // Get form data
        var formData = {
            FirstName: $("#firstName").val(),
            LastName: $("#lastName").val(),
            Gender: $("#gender").val(),
            Age: $("#age").val(),
            Class: $("#class").val()
        };

        // Assume you have a global variable `studentList`
        // If not, you should pass the list to this page or use a service to store data.
        studentList.push(formData);
        console.log("add.js script is running.");
        // Redirect back to the index page
        window.location.href = "/Index";
        console.log("add.js script is running.");
    });
});