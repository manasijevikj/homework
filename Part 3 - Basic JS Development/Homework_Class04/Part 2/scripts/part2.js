var numbers = [3,8,true,16,2];

function validateNumber(num) {
    if(typeof num !== 'number') {
        console.log("Error..")
        return -1;
    }
}

function sum(numbersArray) {
    let result = 0;
    for(let i of numbersArray) {
        if (validateNumber(i) == -1) {
            return false;
        }
        result += i;
    }
    return result;
}

var r = sum(numbers);
if(r != false){
    console.log(r);
}


