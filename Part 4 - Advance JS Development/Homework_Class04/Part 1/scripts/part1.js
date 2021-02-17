$(document).ready(function () {
    let buttonMain = $("#buttonPlanets");
    let tablePlanets = $("#tablePlanets");
    let urlCaller = "https://swapi.dev/api/planets/?page=1";

    function apiCall(urlCall) {
        $.ajax({
            method: "GET",
            url: urlCall,
            success: function (response) {
                printPlanets(response.results);
            },
            error: function (e) {
                console.log(e);
            }
        })
    }

    function printPlanets(data) {

        tablePlanets.empty();
        tablePlanets.append(`<tr><th>Planet Name</th><th>Population</th><th>Climate</th><th>Gravity</th></tr>`);
        $("th").css("border", "solid black 2px");
        $("th").css("background-color", "blue");
        tablePlanets.css("border", "solid black 3px");

        for (let i = 0; i < 10; i++) {
            tablePlanets.append(`<tr><td>${data[i].name}</td><td>${data[i].population}</td><td>${data[i].climate}</td><td>${data[i].gravity}</td></tr>`);
        }
    }

    buttonMain.click(function () {
        apiCall(urlCaller);
        buttonMain.hide();
    });

})