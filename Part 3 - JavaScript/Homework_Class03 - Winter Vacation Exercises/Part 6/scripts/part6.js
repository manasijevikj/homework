var num1 = parseInt(prompt("Number 1:"));
var num2 = parseInt(prompt("Number 2:"));


function triple(num1, num2) {
    let sum;
    if(num1 != num2) {
        sum = num1+num2;
        console.log("Sum: "+sum);
    }
    else {
        sum = (num1+num2)*3;
        console.log("The numbers are same, their sum is tripled: "+sum)
    }
}

triple(num1,num2);