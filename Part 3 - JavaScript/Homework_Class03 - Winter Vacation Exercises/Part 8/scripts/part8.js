var a = parseInt(prompt("Insert the first number"));
var b = parseInt(prompt("Insert the second number"));


// checking if the parameters are numbers
function check(num1, num2) {

    if (isNaN(num1) || isNaN(num2)) {
        if (isNaN(num1)) {
            console.log("First parameter is not good.");
        }

        if(isNaN(num2)) {
            console.log("Second parameter is not good");
        }

        return false;
    }

    else {
        return true;
    }
}


function mainFunction(parameter1, parameter2) {
    let flag = check(parameter1,parameter2);

    if (flag == true) {
        if((parameter1 > 30) || (parameter2 > 30) || ((parameter1+parameter2) == 50)) {
            return true;
        }
        else {
            console.log("Number/s is/are smaller than 30 or their sum is not 50");
        }
    }
}


var back = mainFunction(a,b)
if(back == true) {
    console.log("Number/s is/are bigger than 30 or their sum is 50");
}