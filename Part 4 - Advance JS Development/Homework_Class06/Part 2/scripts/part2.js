$(document).ready(function () {

    const urlPermanent = "https://raw.githubusercontent.com/sedc-codecademy/skwd9-04-ajs/main/Samples/students_v2.json";

    let home = $("#home");
    let task1 = $("#task1");
    let task2 = $("#task2");
    let task3 = $("#task3");
    let task4 = $("#task4");
    let task5 = $("#task5");
    let navItems = $(".nav-item");

    let header = $("#header");
    let error = $("#error")
    let table = $("#result");

    let searchInput = $("#studentSearchInput");
    let searchButton = $("#studentSearchBtn");

    let apiCall = (url, mainFunction) => {
        $.ajax({
            method: "GET",
            url: url,
            success: response => {
                let resultParsed = JSON.parse(response);
                let result = mainFunction(resultParsed);
                mainFunction(result);
            }
            ,
            error: err =>
                console.log(err)
        })
    }

    function addAndRemoveClass(item, navItems) {
        for (let navItem of navItems) {
            $(navItem).removeClass("active");
        }
        item.addClass("active");
    }


    //Functions for creating tables

    //Table for Task1 and Task5
    function fullTable(result, numTask) {
        header.text("");
        table.html("");
        error.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-2">Name</div>
        <div class="col-md-2">Last Name</div>
        <div class="col-md-2">Gender</div>
        <div class="col-md-2">City</div>
        <div class="col-md-2">Average Grade</div>
        <div class="col-md-2">Age</div>
    </div>`);
        result.forEach(student => {
            table.append(`<div class="row">
            <div class="col-md-2">${student.firstName}</div>
            <div class="col-md-2">${student.lastName}</div>
            <div class="col-md-2">${student.gender}</div>
            <div class="col-md-2">${student.city}</div>
            <div class="col-md-2">${student.averageGrade}</div>
            <div class="col-md-2">${student.age}</div>
        </div>`)
        })
    }
    //Table for Task2
    function onlyNameTable(result, numTask) {
        header.text("");
        table.html("");
        error.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-6">Name</div>
        <div class="col-md-6">Average Grade</div>
    </div>`);
        result.forEach(student => {
            table.append(`<div class="row">
        <div class="col-md-6">${student}</div>
        <div class="col-md-6">5</div>
    </div>`)
        })
    }
    //Table for Task3
    function fullNameTable(result, numTask) {
        header.text("");
        table.html("");
        error.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-6">Full Name</div>
        
    </div>`);
        result.forEach(student => {
            table.append(`<div class="row">
        <div class="col-md-6">${student}</div>

    </div>`)
        })
    }
    //Table for Task4
    function avgGradeTable(result, numTask) {
        header.text("");
        table.html("");
        error.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-6">Full Name(with Average Grade)</div>
        
    </div>`);
        result.forEach(student => {
            table.append(`<div class="row">
        <div class="col-md-6">${student}</div>

    </div>`)
        })
    }

    // < Home Listener
    home.click(() => {
        header.text("");
        table.html("");
        addAndRemoveClass(home, navItems);
    })

    // Listener and function1-------
    function task1Function(result) {
        // I have to validate array for using .fiter
        if (Array.isArray(result)) {
            let final = result.filter(student => student.averageGrade > 3);
            fullTable(final, 1);
        }
    }

    task1.click(() => {
        apiCall(urlPermanent, task1Function);
        addAndRemoveClass(task1, navItems);
    })


    // Listener and function2-------
    function task2Function(result) {
        if (Array.isArray(result)) {
            let final = result.filter(student => student.averageGrade === 5 && student.gender === "Female").map(student => student.firstName);
            onlyNameTable(final, 2);
        }
    }

    task2.click(() => {
        apiCall(urlPermanent, task2Function);
        addAndRemoveClass(task2, navItems);
    })


    // Listener and function3-------
    function task3Function(result) {
        if (Array.isArray(result)) {
            let final = result.filter(student => student.age > 18 && student.city === "Skopje").map(student => `${student.firstName} ${student.lastName}`);
            fullNameTable(final, 3);
        }
    }

    task3.click(() => {
        apiCall(urlPermanent, task3Function);
        addAndRemoveClass(task3, navItems);
    })


    // Listener and function4-------
    function task4Function(result) {
        if (Array.isArray(result)) {
            let final = result.filter(student => student.age > 24).map(student => `${student.firstName} ${student.lastName} --- ${student.averageGrade}`);
            avgGradeTable(final, 4);
        }
    }

    task4.click(() => {
        apiCall(urlPermanent, task4Function);
        addAndRemoveClass(task4, navItems)
    })

    // Listener and function5-------
    function task5Function(result) {
        if (Array.isArray(result)) {
            let final = result.filter(student => student.averageGrade > 2 && student.firstName[0] === "B");
            fullTable(final, 5);
        }
    }

    task5.click(() => {
        apiCall(urlPermanent, task5Function);
        addAndRemoveClass(task5, navItems)
    })


    // Listener and functions for search student-------
    function validation(data) {
        if (!data) {
            return false;
        }
        if (typeof (data) !== "string") {
            return false;
        }
        return true;
    }

    function taskBonusFunction(result) {
        if (Array.isArray(result)) {
            let final = result.filter(student => student.firstName.toLowerCase() === searchInput.val().toLowerCase());
            if (final.length !== 0) {
                fullTable(final, "Bonus");
            }
            else {
                header.text("");
                table.html("");
                error.text("The name doesn't exist");
            }
        }
    }

    searchButton.click(() => {
        let searchData = searchInput.val();
        if (validation(searchData)) {

            apiCall(urlPermanent, taskBonusFunction);
        }
        else {
            header.text("");
            error.text("");
            table.html("");
            error.text("Empty Field or incorect text")
        }
    })

})