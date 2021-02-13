var students = [];
var ul1 = document.getElementsByTagName("ul")[0];


function Student(fName, lName, age) {
    this.fName = fName;
    this.lName = lName;
    this.age = age;
}


var save = document.getElementById("buttonS");

save.addEventListener("click", function() {

    let fName = document.getElementById("fName").value;
    let lName = document.getElementById("lName").value;
    let age = document.getElementById("age").value;

    students.push(new Student(fName, lName, age));
    console.log(students);

    var newL = document.createElement("li");
    var textnode = document.createTextNode(`${students[students.length-1].fName} ${students[students.length-1].lName} - ${students[students.length-1].age} years`);
    newL.appendChild(textnode)

    ul1.appendChild(newL);
});


