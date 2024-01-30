
var users = JSON.parse(localStorage.getItem('users')) || [];

var table = document.getElementById('userTable');
var tbody = table.querySelector('tbody');
/*var headerRow = table.querySelector('thead tr');*/

headerRow.classList.add('default-color');

for (var i = 0; i < users.length; i++) {
    var user = users[i];
    var row = tbody.insertRow(-1);

    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    var cell4 = row.insertCell(3);
    var cell5 = row.insertCell(4);

    cell1.innerHTML = user.firstName;
    cell2.innerHTML = user.lastName;
    cell3.innerHTML = user.gender;
    cell4.innerHTML = user.age;
    cell5.innerHTML = user.sclass;

    row.classList.add('default-color');

    if (i === 0) {
        row.classList.add('first-row-color');
    }

    row.addEventListener('click', function (event) {
        var rows = tbody.getElementsByTagName('tr');
        //tbody.rows[0].classList.remove('first-row-color');
        for (var j = 0; j < rows.length; j++) {
            rows[j].classList.remove('selected-color');
        }

        event.currentTarget.classList.add('selected-color');

        var rowIndex = event.currentTarget.rowIndex - 1;
        console.log('Selected Row Index:', rowIndex);
    });

    // Add double-click event listener
    row.addEventListener('dblclick', function (event) {
        var rowIndex = event.currentTarget.rowIndex - 1;
        editUser(rowIndex);
    });
}

// Add event listeners for header clicks
var headerCells = table.querySelectorAll('thead th');
headerCells.forEach(function (cell, index) {
    cell.addEventListener('click', function () {
        sortTable(index);
    });
});

function sortTable(columnIndex) {
    var rows = Array.from(tbody.getElementsByTagName('tr'));

    rows.sort(function (a, b) {
        var cellA = a.getElementsByTagName('td')[columnIndex].textContent;
        var cellB = b.getElementsByTagName('td')[columnIndex].textContent;

        return cellA.localeCompare(cellB);
    });

    tbody.innerHTML = ''; // Clear existing rows

    for (var i = 0; i < rows.length; i++) {
        tbody.appendChild(rows[i]);
    }
}

function AddData() {
    window.location.href = '/AddData';
}

function AddForm() {
    /* window.location.href = '/AddData';*/
    window.location.href = '/AddEdit';
}


function filterTable() {
    var searchTerm = document.getElementById('searchBox').value.toLowerCase();
    var rows = tbody.getElementsByTagName('tr');

    for (var i = 0; i < rows.length; i++) {
        var row = rows[i];
        var cells = row.getElementsByTagName('td');
        var matchFound = false;

        var columnsToSearch = [0, 1, 3];
        for (var j = 0; j < columnsToSearch.length; j++) {
            var columnIndex = columnsToSearch[j];
            var cellText = cells[columnIndex].textContent.toLowerCase();

            if (cellText.includes(searchTerm)) {
                matchFound = true;
                break;
            }
        }

        row.style.display = matchFound ? '' : 'none';
    }
}

function editUser(index) {
    var userToEdit = users[index];
    var editUrl = '/AddData?edit=true&index=' + index +
        '&firstName=' + encodeURIComponent(userToEdit.firstName) +
        '&lastName=' + encodeURIComponent(userToEdit.lastName) +
        '&gender=' + encodeURIComponent(userToEdit.gender) +
        '&dob=' + encodeURIComponent(userToEdit.dob) +
        '&age=' + encodeURIComponent(userToEdit.age) +
        '&class=' + encodeURIComponent(userToEdit.sclass) +
        '&address=' + encodeURIComponent(userToEdit.address);
    window.location.href = editUrl;
}


















//var users = JSON.parse(localStorage.getItem('users')) || [];

//var table = document.getElementById('userTable');
//var tbody = table.querySelector('tbody');
//var headerRow = table.querySelector('thead tr');

//headerRow.classList.add('default-color');

//for (var i = 0; i < users.length; i++) {
//    var user = users[i];
//    var row = tbody.insertRow(-1);

//    var cell1 = row.insertCell(0);
//    var cell2 = row.insertCell(1);
//    var cell3 = row.insertCell(2);
//    var cell4 = row.insertCell(3);
//    var cell5 = row.insertCell(4);

//    cell1.innerHTML = user.firstName;
//    cell2.innerHTML = user.lastName;
//    cell3.innerHTML = user.gender;
//    cell4.innerHTML = user.age;
//    cell5.innerHTML = user.sclass;

//    row.classList.add('default-color');

//    if (i === 0) {
//        row.classList.add('first-row-color');
//    }

//    row.addEventListener('click', function (event) {
//        var rows = tbody.getElementsByTagName('tr');
//        tbody.rows[0].classList.remove('first-row-color');
//        for (var j = 0; j < rows.length; j++) {
//            rows[j].classList.remove('selected-color');
//        }

//        event.currentTarget.classList.add('selected-color');

//        var rowIndex = event.currentTarget.rowIndex - 1;
//        console.log('Selected Row Index:', rowIndex);
//    });

//    // Add double-click event listener
//    row.addEventListener('dblclick', function (event) {
//        var rowIndex = event.currentTarget.rowIndex - 1;
//        editUser(rowIndex);
//    });
//}

//// Add event listeners for header clicks
//var headerCells = table.querySelectorAll('thead th');
//headerCells.forEach(function (cell, index) {
//    cell.addEventListener('click', function () {
//        sortTable(index);
//    });
//});

//function sortTable(columnIndex) {
//    var rows = Array.from(tbody.getElementsByTagName('tr'));

//    rows.sort(function (a, b) {
//        var cellA = a.getElementsByTagName('td')[columnIndex].textContent;
//        var cellB = b.getElementsByTagName('td')[columnIndex].textContent;

//        return cellA.localeCompare(cellB);
//    });

//    tbody.innerHTML = ''; // Clear existing rows

//    for (var i = 0; i < rows.length; i++) {
//        tbody.appendChild(rows[i]);
//    }
//}

//function AddData() {
//    window.location.href = '/AddEdit';
//}
    
//function AddForm() {
//    window.location.href = '/AddData';
//}


//function filterTable() {
//    var searchTerm = document.getElementById('searchBox').value.toLowerCase();
//    var rows = tbody.getElementsByTagName('tr');

//    for (var i = 0; i < rows.length; i++) {
//        var row = rows[i];
//        var cells = row.getElementsByTagName('td');
//        var matchFound = false;

//        var columnsToSearch = [0, 1, 3];
//        for (var j = 0; j < columnsToSearch.length; j++) {
//            var columnIndex = columnsToSearch[j];
//            var cellText = cells[columnIndex].textContent.toLowerCase();

//            if (cellText.includes(searchTerm)) {
//                matchFound = true;
//                break;
//            }
//        }

//        row.style.display = matchFound ? '' : 'none';
//    }
//}

//function editUser(index) {
//    var userToEdit = users[index];
//    var editUrl = '/AddEdit?edit=true&index=' + index +
//        '&firstName=' + encodeURIComponent(userToEdit.firstName) +
//        '&lastName=' + encodeURIComponent(userToEdit.lastName) +
//        '&gender=' + encodeURIComponent(userToEdit.gender) +
//        '&dob=' + encodeURIComponent(userToEdit.dob) +
//        '&age=' + encodeURIComponent(userToEdit.age) +
//        '&class=' + encodeURIComponent(userToEdit.sclass) +
//        '&address=' + encodeURIComponent(userToEdit.address);
//    window.location.href = editUrl;
//}