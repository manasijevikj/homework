$(document).ready(function () {

    let buttonPeople = $("#btnPeople");
    let buttonShips = $("#btnShips");
    let tableResult = $("#tableResult");
    let nextPeople;
    let nextShips;
    let previousPeople;
    let previousShips;

    let pre = $("#btnPrev");
    let next = $("#btnNext");

    let flag = false; // false: showing people, true: showing ships


    buttonPeople.click(function () {
        flag = false;
        $.ajax({
            url: "https://swapi.dev/api/people/?page=1",
            success: function (result) {

                nextPeople = result.next;
                previousPeople = result.previous;
                tableResult.empty();
                tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Height </th> <th> Mass </th> <th> Gender </th> <th> Birth year </th> <th> Films </th> </tr>`)
                $(".trYellow").addClass("yeloowText");
                for (let item of result.results) {
                    tableResult.append(`<tr>`);
                    tableResult.append(`<td> ${item.name}</td> <td> ${item.height}</td> <td> ${item.mass}</td> <td> ${item.gender}</td> <td> ${item.birth_year}</td> <td> ${item.films.length}</td>`);
                    tableResult.append(`</tr>`);
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    })

    buttonShips.click(function () {
        flag = true;
        $.ajax({
            url: "https://swapi.dev/api/starships/?page=1",
            success: function (result) {

                nextShips = result.next;
                previousShips = result.previous;

                tableResult.empty();
                tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Model </th> <th> Manufacturer </th> <th> Cost </th> <th> People Capacity </th> <th> Class </th> </tr>`)
                $(".trYellow").addClass("yeloowText");
                for (let item of result.results) {
                    tableResult.append(`<tr>`);
                    tableResult.append(`<td> ${item.name}</td> <td> ${item.model}</td> <td> ${item.manufacturer}</td> <td> ${item.cost_in_credits}</td> <td> ${item.passengers}</td> <td> ${item.starship_class}</td>`);
                    tableResult.append(`</tr>`);
                }
            },
            error: function (err) {
                console.log(err);
            }
        });
    })

    pre.click(function () {
        if (!flag) {
            $.ajax({
                url: previousPeople,
                success: function (result) {

                    nextPeople = result.next;
                    previousPeople = result.previous;
                    tableResult.empty();
                    tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Height </th> <th> Mass </th> <th> Gender </th> <th> Birth year </th> <th> Films </th> </tr>`)
                    $(".trYellow").addClass("yeloowText");
                    for (let item of result.results) {
                        tableResult.append(`<tr>`);
                        tableResult.append(`<td> ${item.name}</td> <td> ${item.height}</td> <td> ${item.mass}</td> <td> ${item.gender}</td> <td> ${item.birth_year}</td> <td> ${item.films.length}</td>`);
                        tableResult.append(`</tr>`);
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
        else {
            $.ajax({
                url: previousShips,
                success: function (result) {

                    nextShips = result.next;
                    previousShips = result.previous;
                    tableResult.empty();
                    tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Model </th> <th> Manufacturer </th> <th> Cost </th> <th> People Capacity </th> <th> Class </th> </tr>`)
                    $(".trYellow").addClass("yeloowText");
                    for (let item of result.results) {
                        tableResult.append(`<tr>`);
                        tableResult.append(`<td> ${item.name}</td> <td> ${item.model}</td> <td> ${item.manufacturer}</td> <td> ${item.cost_in_credits}</td> <td> ${item.passengers}</td> <td> ${item.starship_class}</td>`);
                        tableResult.append(`</tr>`);
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
    })

    next.click(function () {
        if (!flag) {
            $.ajax({
                url: nextPeople,
                success: function (result) {

                    nextPeople = result.next;
                    previousPeople = result.previous;
                    tableResult.empty();
                    tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Height </th> <th> Mass </th> <th> Gender </th> <th> Birth year </th> <th> Films </th> </tr>`)
                    $(".trYellow").addClass("yeloowText");
                    for (let item of result.results) {
                        tableResult.append(`<tr>`);
                        tableResult.append(`<td> ${item.name}</td> <td> ${item.height}</td> <td> ${item.mass}</td> <td> ${item.gender}</td> <td> ${item.birth_year}</td> <td> ${item.films.length}</td>`);
                        tableResult.append(`</tr>`);
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }
        else {
            $.ajax({
                url: nextShips,
                success: function (result) {

                    nextShips = result.next;
                    previousShips = result.previous;
                    tableResult.empty();
                    tableResult.append(`<tr class="trYellow"> <th> Name </th> <th> Model </th> <th> Manufacturer </th> <th> Cost </th> <th> People Capacity </th> <th> Class </th> </tr>`)
                    $(".trYellow").addClass("yeloowText");
                    for (let item of result.results) {
                        tableResult.append(`<tr>`);
                        tableResult.append(`<td> ${item.name}</td> <td> ${item.model}</td> <td> ${item.manufacturer}</td> <td> ${item.cost_in_credits}</td> <td> ${item.passengers}</td> <td> ${item.starship_class}</td>`);
                        tableResult.append(`</tr>`);
                    }
                },
                error: function (err) {
                    console.log(err);
                }
            });
        }

    })

})