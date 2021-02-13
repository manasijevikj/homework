var birthyYear;

function calculateAge(bYear) {
    let d = new Date();
    let y = d.getFullYear();

    let age = y-bYear;
    console.log("You are "+age+" years old")
}

birthyYear = parseInt(prompt("Insert your birth year:"));
birthyYear = parseInt(birthyYear);
calculateAge(birthyYear);

birthyYear = prompt("Insert your birth year:");
birthyYear = parseInt(birthyYear);
calculateAge(birthyYear);

birthyYear = prompt("Insert your birth year:");
birthyYear = parseInt(birthyYear);
calculateAge(birthyYear);


