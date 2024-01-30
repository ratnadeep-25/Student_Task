document.addEventListener("DOMContentLoaded", function () {
    // Get query parameters from the URL
    const params = new URLSearchParams(window.location.search);
    const firstName = params.get("firstName");
    const lastName = params.get("lastName");

    // Display the data on the destination page
    const displayDataElement = document.getElementById("displayData");
    displayDataElement.innerHTML = `<p>First Name: ${firstName}</p><p>Last Name: ${lastName}</p>`;
});