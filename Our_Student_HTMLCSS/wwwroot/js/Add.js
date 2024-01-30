function getUrlParameter(name) {
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(window.location.href);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

// Function to populate form with user data
function populateFormForEdit(index) {
    var firstName = getUrlParameter('firstName');
    var lastName = getUrlParameter('lastName');
    var gender = getUrlParameter('gender');
    var dob = getUrlParameter('dob');
    var age = getUrlParameter('age');
    var sclass = getUrlParameter('class');
    var address = getUrlParameter('address');

    document.getElementById("firstName").value = firstName;
    document.getElementById("lastName").value = lastName;
    document.getElementById("gender").value = gender;
    document.getElementById("dob").value = dob;
    document.getElementById("age").value = age;
    document.getElementById("class").value = sclass;
    document.getElementById("address").value = address;

}

// Check if 'edit' parameter is present in the URL
var editParameter = getUrlParameter('edit');
if (editParameter === 'true') {
    // If editing, populate the form with existing data
    var editIndex = getUrlParameter('index');
    populateFormForEdit(editIndex);
}
function addOrUpdateUser() {
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var gender = document.getElementById("gender").value;
    var dob = document.getElementById("dob").value;
    var age = document.getElementById("age").value;
    var sclass = document.getElementById("class").value;
    var address = document.getElementById("address").value;


    if (firstName && lastName) {
        var existingUsers = JSON.parse(localStorage.getItem('users')) || [];
        var editIndex = getUrlParameter('index');

        if (editParameter === 'true' && editIndex !== null) {
            // If editing, update existing user data
            existingUsers[editIndex].firstName = firstName;
            existingUsers[editIndex].lastName = lastName;
            existingUsers[editIndex].gender = gender;
            existingUsers[editIndex].dob = dob;
            existingUsers[editIndex].age = age;
            existingUsers[editIndex].sclass = sclass;
            existingUsers[editIndex].address = address;

        } else {
            // If adding, create a new user
            var user = {
                firstName: firstName,
                lastName: lastName,
                gender: gender,
                dob: dob,
                age: age,
                sclass: sclass,
                address: address
            };
            existingUsers.push(user);
        }

        localStorage.setItem('users', JSON.stringify(existingUsers));

        document.getElementById("firstName").value = '';
        document.getElementById("lastName").value = '';
        document.getElementById("gender").value = gender;
        document.getElementById("dob").value = dob;
        document.getElementById("age").value = age;
        document.getElementById("class").value = sclass;
        document.getElementById("address").value = address;

        alert('User saved successfully!');

        // Navigate to datadisplay.html after saving
        window.location.href = 'Index';
    } else {
        alert('Please enter both first name and last name.');
    }
}

function editUser(index) {
    var userToEdit = users[index];
    var editUrl = 'userform.html?edit=true&index=' + index +
        '&firstName=' + encodeURIComponent(userToEdit.firstName) +
        '&lastName=' + encodeURIComponent(userToEdit.lastName) +
        '&gender=' + encodeURIComponent(userToEdit.gender) +
        '&dob=' + encodeURIComponent(userToEdit.dob) +
        '&age=' + encodeURIComponent(userToEdit.age) +
        '&class=' + encodeURIComponent(userToEdit.sclass) +
        '&address=' + encodeURIComponent(userToEdit.address);
    // Redirect to userform.html with edit parameters
    window.location.href = editUrl;
    alert('Edit operation performed.');
}
function cancelUser() {
    window.location.href = 'Index';
}

function deleteUser() {
    var confirmDelete = confirm("Are you sure you want to delete this user?");

    if (confirmDelete) {
        var editIndex = getUrlParameter('index');
        var existingUsers = JSON.parse(localStorage.getItem('users')) || [];

        if (editParameter === 'true' && editIndex !== null) {
            // If editing, show the user data before deletion
            populateFormForEdit();

            // Delete the user at the specified index
            existingUsers.splice(editIndex, 1);
            localStorage.setItem('users', JSON.stringify(existingUsers));

            // Show a success message
            alert('User deleted successfully!');

            // Navigate to datadisplay.html after deletion
            window.location.href = 'Index';
        } else {
            alert('Cannot delete user. No user selected for deletion.');
        }
    }
}