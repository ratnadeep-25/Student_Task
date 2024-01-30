
    // Initial data for the table
    var studentList = [
        { FirstName: "Ajay", LastName: "Patil", Gender: "Male", BirthDate: "2008-01-20", Age: 15, Class: "12th", Address: "Pune" },
        { FirstName: "Ranjeet", LastName: "Jadhav", Gender: "Male", BirthDate: "2006-08-06", Age: 17, Class: "10th", Address: "Mumbai" }
    ];
$(document).ready(function () {
    // Display initial data in the table
    displayStudentTable(studentList);

    // Add button click event
    $("#addButton").on("click", function () {
        window.location.href = "/Add"; // Redirect to the Add page
    });

    function displayStudentTable(studentList) {
        var tableBody = $("#studentTable tbody");
        tableBody.empty(); // Clear existing rows

        $.each(studentList, function (index, student) {
            var row = "<tr><td>" + student.FirstName + "</td><td>" + student.LastName + "</td><td>" + student.Gender + "</td><td>" +
                student.Age + "</td><td>" + student.Class + "</td></tr>";
            tableBody.append(row);
        });
    }
});