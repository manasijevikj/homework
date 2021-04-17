var arr = [2,5,["a","b","c"], null, "sedc", 0];


function check(inputArray) {
    let newArray = []
    for(let i of inputArray) {
        if(!!i) {
            newArray.push(i);
        }
    }
    return newArray;
}

let nArr = check(arr);
console.log(nArr);


