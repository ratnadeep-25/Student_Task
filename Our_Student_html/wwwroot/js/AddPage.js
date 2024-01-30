

document.getElementById('dob').addEventListener('input', function () {
    console.log("enter1");
    var dob = new Date(this.value);

    var today = new Date();

    var age = today.getFullYear() - dob.getFullYear();

    // Adjust age based on month and day

    if (today.getMonth() < dob.getMonth() || (today.getMonth() === dob.getMonth() && today.getDate() < dob.getDate())) {
        console.log("enter2");
        age--;

    }
    console.log("enter3");
    document.getElementById('age').value = age;

});

// Update Date of Birth when Age changes

document.getElementById('age').addEventListener('input', function () {
    console.log("enter4");
    var age = parseInt(this.value);

    if (!isNaN(age) && age >= 0) {
        console.log("enter5");
        var today = new Date();

        var birthYear = today.getFullYear() - age;

        var birthMonth = today.getMonth() + 1; // JavaScript months are 0-indexed

        var birthDay = today.getDate();
        console.log("enter6");
        document.getElementById('dob').value = birthYear + '-' +

            (birthMonth < 10 ? '0' : '') + birthMonth + '-' +

            (birthDay < 10 ? '0' : '') + birthDay;

    }

});

function getUrlParameter(name) {
    name = name.replace(/[\[\]]/g, "\\$&");
    var regex = new RegExp("[?&]" + name + "(=([^&#]*)|&|#|$)"),
        results = regex.exec(window.location.href);
    if (!results) return null;
    if (!results[2]) return '';
    return decodeURIComponent(results[2].replace(/\+/g, " "));
}

 //Function to populate edit form with user data
function populateFormForEdit(index) {
    var firstName = getUrlParameter('firstName');
    var lastName = getUrlParameter('lastName');
    var gender = getUrlParameter('gender');
    var dob = getUrlParameter('dob');
    var age = getUrlParameter('age');
    var sclass = getUrlParameter('sclass');
    var address = getUrlParameter('address');

    document.getElementById("firstName").value = firstName;
    document.getElementById("lastName").value = lastName;
    document.getElementById("gender").value = gender;
    document.getElementById("dob").value = dob;
    document.getElementById("age").value = age;
    document.getElementById("sclass").value = sclass;
    document.getElementById("address").value = address;

}

// Check if 'edit' parameter is present in the URL
var editParameter = getUrlParameter('edit');
if (editParameter === 'true') {
    // If editing, populate the form with existing data
    var editIndex = getUrlParameter('index');
    populateFormForEdit(editIndex);
}

function Save1() {
    var firstName = document.getElementById("firstName").value;
    var lastName = document.getElementById("lastName").value;
    var gender = document.getElementById("gender").value;
    var dob = document.getElementById("dob").value;
    var age = document.getElementById("age").value;
    var sclass = document.getElementById("sclass").value;
    var address = document.getElementById("address").value;

    console.log(dob);

    var isFirstNameValid = firstNameValidation();
    var isLastNameValid = lastNameValidation();
    var isGenderValid = genderValidation();
    var isDobValid = dobValidation();
    var isAgeValid = ageValidation();
   

    if (isFirstNameValid && isLastNameValid && isGenderValid && isDobValid && isAgeValid) {
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
        document.getElementById("sclass").value = sclass;
        document.getElementById("address").value = address;

        /*alert('User saved successfully!');*/

        // Navigate to datadisplay.html after saving
        window.location.href = 'Index';
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
        '&sclass=' + encodeURIComponent(userToEdit.sclass) +
        '&address=' + encodeURIComponent(userToEdit.address);
    // Redirect to userform.html with edit parameters
    window.location.href = editUrl;
    alert('Edit operation performed.');
}
function cancelUser() {
    window.location.href = 'Index';
}

function delete1() {
    console.log("Enter");
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
            //alert('User deleted successfully!');

            // Navigate to datadisplay.html after deletion
            window.location.href = 'Index';
        } else {
            alert('Cannot delete user. No user selected for deletion.');
        }
    }
}
var firstName = document.getElementById("firstName");

var firstNameValidation = function () {
    // console.log("enter2");
    var firstNameValue = firstName.value.trim().replace(/\s/g, '');

    var validFirstName = /^[A-Za-z]+$/;
    //console.log(firstNameValue.length);
    /*validFirstName = /^[A-Za-z]+$/;*/
    firstNameErr = document.getElementById('first-name-err');

    if (firstNameValue === "" && !validFirstName.test(firstNameValue)) {
        firstNameErr.innerHTML = "This field is required.";
       /* console.log("f1");*/
    }
    else if (firstNameValue.length < 3 || firstNameValue.length > 18) {
        firstNameErr.innerHTML = "First Name must be between 3 and 15 characters.";
       /* console.log("f2");*/
    } else {
        firstNameErr.innerHTML = "";
        /*console.log("f3");*/
        return true;
    }
};
firstName.oninput = function () {

    firstNameValidation();
}

var lastName = document.getElementById("lastName");

var lastNameValidation = function () {
    var lastNameValue = lastName.value.trim().replace(/\s/g, '');
    validLastName = /^[A-Za-z]+$/;

    lastNameErr = document.getElementById('last-name-err');
    if (lastNameValue === "") {
        lastNameErr.innerHTML = "This field is required.";
    }

    else if (lastNameValue.length < 2 || lastNameValue.length > 18) {
        lastNameErr.innerHTML = "Last Name must be between 2 and 18 characters.";
    } else {
        lastNameErr.innerHTML = "";
        return true;
    }
};


lastName.oninput = function () {
    lastNameValidation();
}

/*var gender = document.getElementById("gender").value;*/
var genderValidation = function () {
    var genderInput = document.getElementById("gender");
    var genderValue = genderInput.value;
   /* console.log(genderValue);*/
    genderErr = document.getElementById('gender-err');


    if (genderValue === "") {
        /*console.log(genderValue);*/
        genderErr.innerHTML = "This field is required.";
        console.log("g1");
    } else {
        genderErr.innerHTML = "";
        /*console.log("g2");*/
        return true;
    }
};

gender.oninput = function () {
    genderValidation();
}



var ageValidation = function () {

    var ageInput = document.getElementById("age").value;
    var ageValue = parseInt(ageInput, 10);
    var ageErr = document.getElementById('age-err');

    console.log(ageValue);

    if (ageInput.trim() === "") {
        ageErr.innerHTML = "This field is required.";
        return false;
    }

    if (isNaN(ageValue) || ageValue < 5 || ageValue > 99) {
        ageErr.innerHTML = "Age should be <br/> between 5 and 99";
       /* console.log(ageErr.innerHTML);*/
        /*console.log("age1");*/
        return false;
    } else {
        /*console.log("check1");*/
        dob.oninput();
        ageErr.innerHTML = "";
        /*dobErr.innerHTML = "";*/
        /*console.log("no age error");*/
        return true;
    }
};

age.oninput = function () {
    ageValidation();
    //dob.oninput();
}

var dob = document.getElementById("dob");
var dobValidation = function () {
    
    dobValue = dob.value;
    dobErr = document.getElementById('dob-err');
    var today = new Date();

    if (!dobValue) {
       /* console.log(dobValue);*/
        if (dobValue=="" || dobValue == today) {
            dobErr.innerHTML = "This field is required";
            
            return false;
        }
        else {
            /*age.oninput();*/
            dobErr.innerHTML = "";
            /*console.log("d21");*/
            return true;
        }
        
    } else {
        /*age.oninput();*/
        dobErr.innerHTML = "";
        /*console.log("d2");*/
        return true;
    }

   
};

dob.oninput = function () {
    /*console.log("check2");*/
    dobValidation();
    //age.oninput();
};




