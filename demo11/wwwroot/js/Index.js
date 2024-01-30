function sendData() {
    const firstName = document.getElementById("firstName").value;
    const lastName = document.getElementById("lastName").value;

    // Build the URL with query parameters
    const DUrl = `D.html?firstName=${encodeURIComponent(firstName)}&lastName=${encodeURIComponent(lastName)}`;

    // Redirect to the destination page
    window.location.href = DUrl;
}