$(document).ready(function () {
    let buttonMain = $("#buttonPlanets");
    let tablePlanets = $("#tablePlanets");
    let urlCaller = "https://swapi.dev/api/planets/?page=";

    let previous = $("#preButton").css("display", "none");;
    let next = $("#nextButton").css("display", "none");;
    let page = 1;

    let apiCall = urlCall => {
        $.ajax({
            method: "GET",
            url: `${urlCall}${page}`,
            success: response =>
                printPlanets(response.results)
            ,
            error: err =>
                console.log(err)
        })
    }

    let printPlanets = data => {

        tablePlanets.empty();
        tablePlanets.append(`<tr><th>Planet Name</th><th>Population</th><th>Climate</th><th>Gravity</th></tr>`);
        $("th").css("border", "solid black 2px");
        $("th").css("background-color", "blue");

        tablePlanets.css("border", "solid black 2px");

        for (let i = 0; i < 10; i++) {
            tablePlanets.append(`<tr><td>${data[i].name}</td><td>${data[i].population}</td><td>${data[i].climate}</td><td>${data[i].gravity}</td></tr>`);
        }
    }

    let toggleElement = (toggleCondition, element) => {
        if (toggleCondition) {
            element.css("display", "block");
        }
        else {
            element.css("display", "none");
        }
    }

    buttonMain.click(() => {
        apiCall(urlCaller);
        toggleElement(false, buttonMain);
        toggleElement(true, next);
    });

    next.click(() => {
        page = 2;
        apiCall(urlCaller);
        toggleElement(false, next);
        toggleElement(true, previous);
    })

    previous.click(() => {
        page = 1;
        apiCall(urlCaller);
        toggleElement(true, next);
        toggleElement(false, previous);
    })

})