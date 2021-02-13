function convert(option, years) {

    if (option == "human") {
        let result = years*7;
        return result;
    }
    
    else {
        let result = years/7;
        return result;
    }
}


var option = prompt("1. If you want to convert Human's years to Dog's years write \"Human\". \n2. If you want to convert Dog's years to Human's yeras write \"Dog\".");
option = option.toLowerCase();
console.log(option);
var years = prompt("Years:");
years = parseInt(years);

while(option != "human" && option != "dog") {

    console.log("Incorrect input, try again")
    option = prompt("1. If you want to convert Human's years to Dog's years write \"Human\". \n2. If you want to convert Dog's years to Human's yeras write \"Dog\".");
    option = option.toLowerCase();
    console.log(option);
    years = prompt("Years:");
    years = parseInt(years);
}


var resultF = convert(option, years);
console.log("Result: "+resultF);


