let button = document.getElementById("click");
let table = document.getElementsByTagName("table")[0];


button.addEventListener("click", function () {

    fetch("https://jsonplaceholder.typicode.com/users/1")
        .then(function (response) {
            response.json()
                .then(function (data) {
                    table.innerHTML = '';

                    let header = document.createElement("tr");
                    header.innerHTML = "<th>Name</th><th>Username </th> <th> Phone</th> <th>Email </th> <th>City </th> ";
                    table.appendChild(header);
                    header.style.backgroundColor = "yellow";

                    let dataFirst = document.createElement("tr");
                    dataFirst.innerHTML = `<td>${data.name}</td><td>${data.username}</td> <td> ${data.phone}</td> <td>${data.email} </td> <td>${data.address.city}</td>`;
                    table.appendChild(dataFirst);
                    dataFirst.style.backgroundColor = "#D4EDDA";
                    table.style.border = "3px solid black";
                })
        })
        .catch(function (error) {
            //error
        });
})