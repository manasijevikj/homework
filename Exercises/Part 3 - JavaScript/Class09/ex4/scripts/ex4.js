let arrayString = ["array of", "js string", "is fun to use", "make sure to properly", "tell the array size"];

function largestString(arraySting) {
    let maxL = 0;
    let maxS = "";
    for(let i in arraySting) {

        if(arraySting[i].length > 10)
        {
            console.log("The first string larger then 10 characters")
            return arraySting[i];
        }
        else if(arraySting[i].length > maxL){
            maxL = arraySting[i].length;
            maxS = arraySting[i];
        }
    }
    console.log("The largest string in the array")
    return maxS;
}

let r = largestString(arrayString);
console.log(r);


