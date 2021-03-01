$(document).ready(function () {
    let home = $("#home");

    let table = $("#result");
    let tabelUser = $("#resultUser")
    let number = 1;


    function getUserId(data) {
        let result = data.userId
        return result;
    }

    // functions for tables
    function createTablePost(user) {
        table.append(`<thead 
        <tr>
        <th scope="col">User ID</th>
          <th scope="col">ID</th>
          <th scope="col">Title</th>
          <th scope="col">Body</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <th scope="row">${user.userId}</th>
            <td>${user.id}</td>
            <td>${user.title}</td>
            <td>${user.body}</td>
        </tr>
    </tbody>`)
    }

    function createTableUser(user) {
        tabelUser.append(`<thead 
        <tr>
          <th scope="col">ID</th>
          <th scope="col">Name</th>
          <th scope="col">Username</th>
          <th scope="col">Email</th>
          <th scope="col">City</th>
          <th scope="col">Website</th>
          <th scope="col">Company name</th>
        </tr>
        </thead>
        <tbody>
        <tr>
            <td>${user.id}</td>
            <td>${user.name}</td>
            <td>${user.username}</td>
            <td>${user.email}</td>
            <td>${user.address.city}</td>
            <td>${user.website}</td>
            <td>${user.company.name}</td>
        </tr>
    </tbody>`)
    }

    // main function
    async function getData(number) {
        let response = await fetch(`https://jsonplaceholder.typicode.com/posts/${number}`);
        let data = await response.json();
        createTablePost(data);
        let userId = getUserId(data);
        let responseUser = await fetch(`https://jsonplaceholder.typicode.com/users/${userId}`);
        let dataUser = await responseUser.json();
        createTableUser(dataUser);
    }


    getData(number);


})