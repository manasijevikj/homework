function numFunction (inputArray) {

    let even = [];
    let odd = [];
    for(let i of inputArray) {
        if (isNaN(i)) {
            console.log("It's not a array of numbers");
            return false;
        }
        else {
            if (i%2==0) {
                even.push(i);
            }
            else {
                odd.push(i);
            }
        }
    }
    return [even, odd];
}


console.log(`Even: ${numFunction([1,2,3,"s",5,6,7,8,9])[0]}`);
console.log(`Odd: ${numFunction([1,2,3,4,5,6,7,8,9])[1]}`);
