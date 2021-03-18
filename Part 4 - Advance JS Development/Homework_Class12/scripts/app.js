$(document).ready(function () {

    let navItems = $(".nav-item");
    let home = $("#home");
    let task1 = $("#task1");
    let task2 = $("#task2");
    let task3 = $("#task3");
    let mainDiv = $("#mainDiv")

    let studentsArray = [];


    //Creating Person class
    class Person {
        constructor(firstName, lastName, age, address) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
        }

        fullName() {
            return `${this._firstName} ${this._lastName}`;
        }


        get firstName() {
            return this._firstName;
        }
        set firstName(fName) {
            console.log("We are setting the First Name of the Person. Please wait...")
            fName.length > 1 && typeof (fName) === "string" ? this._firstName = fName :
                (() => { throw new Error("Invalid First Name!") })();
        }

        get lastName() {
            return this._lastName;
        }

        set lastName(lName) {
            console.log("We are setting the Last Name of the Person. Please wait...")
            lName.length > 1 && typeof (lName) === "string" ? this._lastName = lName :
                (() => { throw new Error("Invalid Last Name!") })();
        }



        get age() {
            return this._age;
        }
        set age(ageP) {
            console.log("We are setting the Age of the Person. Please wait...")
            ageP > 0 && ageP < 100 && typeof ageP === "number" ? this._age = ageP :
                (() => { throw new Error("Invalid Age") })();
        }

        get address() {
            return this._address;
        }
        set address(addressP) {
            console.log("We are setting the Address of the Person.. Please wait...")
            addressP.length > 5 && typeof addressP === "string" ? this._address = addressP :
                (() => { throw new Error("Invalid Address!") })();
        }

    }



    //Creating Student class
    class Student extends Person {
        constructor(firstName, lastName, age, address, academy, subjects) {
            super(firstName, lastName, age, address);
            this.subjects = subjects;
            this.academy = academy;
        }

        static checkStudentAndSubject(student, subject) {
            subject = subject.toLowerCase();
            if (!(student instanceof Student)) {
                return `Your first parametar is not type Student`
            }
            else {
                if (student.subjects.includes(subject)) {
                    return `The student studies the subject ${subject}`;
                }
                else {
                    return `The student doesn't study the subject`;
                }
            }
        }


        get subjects() {
            return this._subjects;
        }
        set subjects(subjectsS) {
            console.log("We are setting the Subjects of the Student. Please wait...")
            Array.isArray(subjectsS) ? this._subjects = subjectsS :
                (() => { throw new Error("Subjects is invalid") })();
        }

        get academy() {
            return this._academy;
        }
        set academy(academyS) {
            console.log("We are setting the Academy of the Person.. Please wait...")
            academyS.length > 1 && typeof (academyS) === "string" ? this._academy = academyS :
                (() => { throw new Error("Academy is invalid!") })();
        }
    }

    function addAndRemoveClass(item, navItems) {
        for (let navItem of navItems) {
            $(navItem).removeClass("active");
        }
        item.addClass("active");
    }


    // student1 = new Student("Aleksandar", "Manasijevikj", 29, "Volgogradska 2", "Sedc", ["html", "css"])
    // studentsArray = [student1];


    //Home
    home.click(() => {
        mainDiv.html("");
        addAndRemoveClass(home, navItems);
    })


    //Create Students


    //Form for Create Student
    function createTable() {
        mainDiv.html("");
        mainDiv.append(`        <div class="jumbotron jumbotron-fluid" id="libForm">
        <div class="container">
            <h1 class="text-center" >Create Student</h1>
            <hr class="my-4">
                
            <div class="row">
                <div class="col" id="alertId">
                    
                </div>
             </div>

            <form>
                <div class="row">
                    <div class="col">
                        <input type="text" class="form-control" id="firstNameInput" placeholder="First name">
                    </div>
                    <div class="col">
                        <input type="text" class="form-control" id="lastNameInput" placeholder="Last name">
                    </div>
                    <div class="col">
                        <input type="number" class="form-control" id="ageInput" placeholder="Age">
                    </div>
                    <hr class="my-4">
                </div>

                <hr class="my-4">
                <div class="row">
                    <div class="col">
                        <input type="text" class="form-control" id="addressInput" placeholder="Address">
                    </div>
                    <div class="col">
                        <input type="text" class="form-control" id="academyInput" placeholder="Academy">
                    </div>
                </div>

                <hr class="my-4">
                <div class="row">
                    <div class="input-group mb-3 container">
                        <input type="text" class="form-control" id="subjectInput"
                            placeholder="Subjects">
                        <div class="input-group-append">
                            <button class="btn btn-dark" type="submit" id="addButton">Add Subject</button>
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="input-group mb-3 container">
                        <ul class="list-group col-md-3 text-light text-center" id="ulSubjects">
                        </ul>
                    </div>
                </div>

                <hr class="my-4">
                <div class="container">
                    <div class="row">
                        <div class="col-md-12 text-right">
                            <button type="button" class="btn btn-warning btn-lg" id="createButton">Create</button>
                        </div>
                    </div>
                </div>

            </form>
        </div>

    </div>`)
    }


    //Functions and Listener for Create Student

    // Adding Subjects function
    function addSub(subjects) {
        let li = $("#subjectInput").val();
        console.log(li);
        if (!li) {
            return;
        }
        $("#ulSubjects").append(`<li class="list-group-item bg-dark">${li}</li>`);
        li = li.toLowerCase()
        subjects.push(li);
        $("#subjectInput").val("");
        return subjects;

    }

    // Getting input values and creating new Student
    function createStudent(subjects) {
        let fName = $("#firstNameInput").val();
        let lName = $("#lastNameInput").val();
        let age = $("#ageInput").val();
        age = parseInt(age);
        let address = $("#addressInput").val();
        let academy = $("#academyInput").val();


        //Creating new Student
        let student = new Student(fName, lName, age, address, academy, subjects);
        studentsArray.push(student);
    }


    //Listener for Create Student
    task1.click(function () {
        mainDiv.html("");
        addAndRemoveClass(task1, navItems);

        let subjects = [];
        createTable();

        $("#addButton").click(function () {
            addSub(subjects);
        })

        $("#createButton").click(function () {
            try {
                createStudent(subjects);
                $("#firstNameInput").val("");
                $("#lastNameInput").val("");
                $("#ageInput").val("");
                $("#addressInput").val("");
                $("#academyInput").val("");
                $("#ulSubjects").html("");
                subjects = [];
                $("#alertId").html("")
                $("#alertId").append(`<div class="alert alert-success text-center" role="alert">The Student is created
                    </div>`)
            }
            catch (err) {

                //Catching errors and Alert
                $("#alertId").html("")
                $("#alertId").append(`<div class="alert alert-danger text-center" role="alert">${err}
                    </div>`)
            }
        })
    })


    //Show Students

    //Functions and Listener for Show Students
    function createTableStudents() {
        mainDiv.html("");
        mainDiv.append(`            <div class="jumbotron jumbotron-fluid" id="libForm">
        <div class="container">
            <h1 class="text-center">Students Info</h1>
            <hr class="my-4">
            <h3 class="text-center text-danger" id="h3Table"></h3>
            <table class="table table-striped table-dark" id="result">
                <thead>
                    <tr>
                        <th scope="col">First Name</th>
                        <th scope="col">Last Name</th>
                        <th scope="col">Age</th>
                        <th scope="col">Address</th>
                        <th scope="col">Academy</th>
                        <th scope="col">Subjects</th>
                    </tr>
                </thead>
                <tbody id="tbId">

                </tbody>
            </table>
        </div>
    </div>`)

        for (let student of studentsArray) {
            $("#tbId").append(`                        <tr> <td>${student._firstName}</td>
        <td>${student._lastName}</td>
        <td>${student._age}</td>
        <td>${student._address}</td>
        <td>${student._academy}</td>
        <td>${student._subjects}</td></tr>`);
        }
    }

    task2.click(function () {
        mainDiv.html("");
        addAndRemoveClass(task2, navItems);

        createTableStudents();
        if (studentsArray.length === 0) {
            $("#result").html("");
            $("#h3Table").text("Students Table is empty")
        }
    })



    //Check Subject

    //Functions and Listener for Check Subject
    function checkSubjectForm() {
        mainDiv.html("");
        mainDiv.append(`        <div class="jumbotron jumbotron-fluid" id="libForm">
        <div class="container">
            <h1 class="text-center" >Check Subject</h1>
            <hr class="my-4">

            <form>
                <div class="row">
                    <div class="col">
                        <input type="text" class="form-control" id="firstNameInput" placeholder="First name">
                    </div>
                    <div class="col">
                        <input type="text" class="form-control" id="lastNameInput" placeholder="Last name">
                    </div>
                    <div class="col">
                    <button class="btn btn-dark" type="submit" id="checkButton">Check Student</button>
                </div>
                    <hr class="my-4">
                </div>

                <div class="row">
                <div class="col" id="alertIdCheck">
                    
                </div>
             </div>

                <hr class="my-4">
                <div class="row">
                    <div class="input-group mb-3 container">
                        <input type="text" class="form-control" id="subjectInput"
                            placeholder="Subject">
                        <div class="input-group-append">
                            <button class="btn btn-dark" type="submit" id="chechSubButton">Check Subject</button>
                        </div>
                    </div>
                </div>
                <h3 class="text-center"id="h3Sub"> </h3>
            </form>
        </div>
    </div>`)
    }
    //Does student(object from class Student) exist by full name
    function checkFullName() {
        let fName = $("#firstNameInput").val();
        let lName = $("#lastNameInput").val();
        fn = `${fName} ${lName}`
        fn = fn.toLowerCase();
        console.log(fn);
        return fn;
    }

    //Funcion. Do enterd names match with existing student?
    function checkFromStudentsArray(f) {
        let res = studentsArray.filter(student => student.fullName().toLowerCase() === f);
        console.log(res);
        return res;
    }

    task3.click(function () {
        let flag = false;
        mainDiv.html("");
        addAndRemoveClass(task3, navItems);

        let fullN = "";
        checkSubjectForm();

        $("#checkButton").click(function () {
            $("#h3Sub").text("");
            fullN = checkFullName();
            person = checkFromStudentsArray(fullN);

            // console.log(person[0] instanceof Student);
            $("#firstNameInput").val("");
            $("#lastNameInput").val("");

            if (person.length > 0) {
                $("#alertIdCheck").html("");
                $("#alertIdCheck").append(`<div class="alert alert-success text-center" role="alert">${person[0].fullName()} exists
                </div>`);

                $("#chechSubButton").click(function () {

                    let sub = $("#subjectInput").val().toLowerCase();
                    let res = Student.checkStudentAndSubject(person[0], sub);

                    console.log(res);
                    $("#h3Sub").text(res);
                    $("#subjectInput").val("");
                })

            }
            else {
                fullN = fullN.replace(/\w\S*/g, (w) => (w.replace(/^\w/, (c) => c.toUpperCase())));
                $("#alertIdCheck").html("")
                $("#alertIdCheck").append(`<div class="alert alert-danger text-center" role="alert">${fullN} doesn't exist
                </div>`)
                flag = true;
            }
        })

        $("#chechSubButton").click(function () {
            $("#h3Sub").text("");
            $("#h3Sub").text("You have to check first if student exists");
        })

    })

})