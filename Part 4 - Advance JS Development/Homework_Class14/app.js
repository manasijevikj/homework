const textService = require("./textService");
const http = require("http");
const hostname = "127.0.0.1";
const port = 3000;


function Student(firstName, lastName, age, gender, avgGrade) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = gender;
    this.avgGrade = avgGrade;
}

let students = [
    new Student("Ned", "Perkins", 21, "male", 8.5),
    new Student("Makayla", "Richards", 18, "female", 9.5),
    new Student("Adaline", "Snyder", 24, "female", 7.9),
    new Student("Stefano", "Pham", 27, "male", 9),
]

let studentsJson = JSON.stringify(students);
textService.writeFile(studentsJson);
let contentStudents = textService.readAndParseJsonFile();
console.log(contentStudents);


const server = http
    .createServer((req, res) => {
        res.statusCode = 200;
        res.setHeader("Content-Type", "application/json");
        res.write(studentsJson);
        res.end("");
    })
server.listen(port, hostname, () => {
    console.log(`Server is listening on ${hostname} - ${port}`);
});


