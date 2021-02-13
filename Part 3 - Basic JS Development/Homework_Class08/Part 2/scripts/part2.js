$(document).ready(function(){

    let colors = ["red", "blue", "green", "yellow", "black", "pink", "cyan", "purple", "pink", "brown", "gray"];
    let button = $("button");
    let in1 = $("#in1");
    let in2 = $("#in2");
    let h3 = $("h3");


    button.click(function() {

        in2a = in2.val().toLowerCase();
        let flag = false;

        for(let i of colors) {
            if(in2a == i) {
                flag = true;
            }
        }

        if(in1.val().length == 0 || in2.val().length == 0) {
            h3.text("The text filed is empty");
        }
        else if(!flag) {
            h3.text("");
            h3.text("Incorrect Color");
        }
        else{
            h3.text("");
            button.after(`<h1> ${in1.val()} </h1>`);
            let h1 = $("h1:first");
            h1.css("color", in2a);
        }

    })


});


