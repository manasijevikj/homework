function checkNum(num) {

    let flag = false;

    if(isNaN(num))
    {
        console.log("Your input is not a number")
    }
    else {
        if(num > 0) {
            console.log("Positive number");
        }
        else if (num < 0){
            console.log("Negative number");
            flag = true;
        }
        else {
            console.log("Zero");
        }

        if(flag) {
            console.log(`Number of digits: ${num.toString().length-1}`);
        }
        else {
            console.log(`Number of digits: ${num.toString().length}`);
        }

        if(num%2==0) {
            console.log("Number is even");
        }
        else {
            console.log("Number is odd");
        }
    }
}

checkNum(-24);


