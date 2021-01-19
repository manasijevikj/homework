var in1 = prompt("Kilograms:");

function weightInChickens(input) {
    let chickens= input*2;
    chickens = parseInt(chickens);
    
    return chickens;
}

var r = weightInChickens(in1);

var myBody = document.getElementsByTagName("body")[0];
var title1 = document.createElement("h1");
title1.innerText += "WEIGHT CALCULATOR IN CHICKENS";
myBody.appendChild(title1);

var finalResult = document.createElement("p");
finalResult.innerText += `CHICKENS: ${r}`;
myBody.appendChild(finalResult);
