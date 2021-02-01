$(document).ready(function () {

    function dashesEvenNumbers(arrayNumbers) {

        let newArray = [];

        for (let i of arrayNumbers) {
            if (isNaN(i)) {
                return false;
            }
        }

        for (let i = 1; i <= arrayNumbers.length; i++) {

            newArray.push(arrayNumbers[i-1]);

            if (arrayNumbers[i-1]%2 == 0 && arrayNumbers[i]%2 == 0) {
                newArray.push("-");
            }
            
        }

        return newArray;
    }

    let insertArray = [0,2,5,4,6,8];

    let finalArray = dashesEvenNumbers(insertArray);
    if(!finalArray) {
        console.log("it's not a array of numbers");
    }
    else {
        console.log(finalArray);
    }

})