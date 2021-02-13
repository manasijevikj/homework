var a = parseInt(prompt("Insert the first number"));

// checking if the parameter is number
function check(num1) {

    if (isNaN(num1)) {
        console.log("The parameter is not a number.");
        return false;
    }

    else {
        return true;
    }
}

function divBy3(a) {
    var flag = check(a);

    if (flag) {
        if (a%3 == 0) {
            console.log(a+" is divisible by 3");
        } else {
            console.log(a+" is NOT divisible by 3");
        }
    }
}

divBy3(a);


