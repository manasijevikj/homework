function createString(p1, p2, p3, p4) {
    let myString = p1+" "+p2+" "+p3+" "+p4;
    let pElement =  document.createElement("p");
    pElement.innerText = myString;
    document.getElementsByTagName("body")[0].appendChild(pElement);
}


function getValues() {
    let fName = document.getElementById("firstName").value;
    let lName = document.getElementById("lastName").value;
    let email = document.getElementById("email").value;
    let password = document.getElementById("password").value;

    createString(fName, lName, email, password);
}

let button = document.getElementById("button");
button.addEventListener("click", getValues);


