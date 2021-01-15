var firstN = ["Thierry", "Uma", "Jayson", "Lana"];
var lastN = ["Henry", "Thurman", "Tatum", "Del Rey"];


function fullName(firstNames, lastNames) {
    let final = [];
    let temp = "";

    for (let i = 0; i < firstNames.length; i++) {
        temp = (i+1)+". "+firstNames[i]+" "+lastNames[i];
        final.push(temp);
    }

    return final;
}

var finalNames = fullName(firstN, lastN)
console.log(finalNames);
