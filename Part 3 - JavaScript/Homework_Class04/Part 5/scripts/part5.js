var sumArray = [3,2,"5",9,66,"Hi",1,null,0,-6,5, true, 52]

function sumOfMinMax(inputArray) {
    let min = Infinity;
    let max = -Infinity;
    let sum = 0;
    let counter = 0;

    for (let i of inputArray) {
        if (typeof(i) === 'number') {
            if (i > max) {
                max = i;
                counter++;
            }
            
            if (i < min) {
                min = i;
                counter++;
            }
         }
    }

     if (counter > 2) {
        return sum = min+max;
    }
    else{
        return -1;
    }
}

var sumOf = sumOfMinMax(sumArray); 
if (sumOf == -1) {
    console.log("You have only one or zero number in your array")
}
else{
    console.log("Sum of min and max: "+sumOf);
}
