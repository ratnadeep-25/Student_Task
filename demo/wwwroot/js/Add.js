let dataArray = [];

function saveAndRedirect() {
    const firstName = document.getElementById("firstName").value;
    const lastName = document.getElementById("lastName").value;

    if (firstName && lastName) {
        const data = {
            firstName: firstName,
            lastName: lastName
        };

        dataArray.push(data);

        // Clear input fields
        document.getElementById("firstName").value = "";
        document.getElementById("lastName").value = "";

        // Redirect to the data display page
        window.location.href = "Data.html";
    } else {
        alert("Please enter both first name and last name.");
    }
}

function displayData() {
    const tableBody = document.getElementById("dataTableBody");
    tableBody.innerHTML = "";

    dataArray.forEach((data, index) => {
        const row = tableBody.insertRow();
        const cell1 = row.insertCell(0);
        const cell2 = row.insertCell(1);

        cell1.innerHTML = data.firstName;
        cell2.innerHTML = data.lastName;
    });
}