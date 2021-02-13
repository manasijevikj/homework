$(document).ready(function () {

    let clickButton = $("#clickButton");
    let uList = $("ul");

    clickButton.click(function () {
        uList.empty();
        $.ajax({
            url: "https://pokeapi.co/api/v2/pokemon",
            success: function (response) {

                for (let i = 0; i < 10; i++) {
                    console.log(response.results[i]);
                    uList.append(`<li>Name: ${response.results[i].name} -- URL: ${response.results[i].url} </li>`);
                }

            },
            error: function (response) {
                console.log("The request failed!");
                console.log(response);
            }
        })
    })

})