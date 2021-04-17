$(document).ready(function () {

    let buttonPeople = $("#btnPeople");
    let buttonShips = $("#btnShips");
    let listResult = $("#listResult");
    let nextPeople;
    let nextShips;
    let previousPeople;
    let previousShips;

    let pre = $("#btnPrev");
    let next = $("#btnNext");

    let flag = false; // false: showing people, true: showing ships


    buttonPeople.click(function() {
        flag = false;
        $.ajax({
            url: "https://swapi.dev/api/people/?page=1",
            success: function(result){ 

                nextPeople = result.next;
                previousPeople = result.previous;
                listResult.empty();

                for(let item of result.results){ 

                    listResult.append(`<li>Name: ${item.name} -- Height: ${item.height}cm</li>`);
                }
            },
            error: function(err){
                console.log(err);
            }
        });
    })

    buttonShips.click(function() {
        flag = true;
        $.ajax({
            url: "https://swapi.dev/api/starships/?page=1",
            success: function(result){ 

                nextShips = result.next;
                previousShips = result.previous;

                listResult.empty();

                for(let item of result.results){ 

                    listResult.append(`<li>Name: ${item.name} -- Model: ${item.model}</li>`);
                }
            },
            error: function(err){
                console.log(err);
            }
        });
    })

    pre.click(function() {
        
            $.ajax({
                url: previousPeople,
                success: function(result){ 
    
                    nextPeople = result.next;
                    previousPeople = result.previous;
                    listResult.empty();
    
                    for(let item of result.results){ 
    
                        listResult.append(`<li>Name: ${item.name} -- Height: ${item.height}cm</li>`);
                    }
                },
                error: function(err){
                    console.log(err);
                }
            });
        
    })


    next.click(function() {
        $.ajax({
            url: nextPeople,
            success: function(result){ 

                nextPeople = result.next;
                previousPeople = result.previous;
                listResult.empty();

                for(let item of result.results){ 

                    listResult.append(`<li>Name: ${item.name} -- Height: ${item.height}cm</li>`);
                }
            },
            error: function(err){
                console.log(err);
            }
        });
    })




})