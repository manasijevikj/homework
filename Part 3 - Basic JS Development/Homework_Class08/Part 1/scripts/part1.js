$(document).ready(function(){
    let input = $("#inputName");
    let button = $("button");
    let h1 = $("h1");

    button.click(function(e) {
        h1.text(`Hello there ${input.val()}`);
    })

});