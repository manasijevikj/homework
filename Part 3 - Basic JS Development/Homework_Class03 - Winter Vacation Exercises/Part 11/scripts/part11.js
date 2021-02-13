var sentence = prompt("Write something..");
var na = "na";

function lastTwo(s) {
    let end = sentence.substring(sentence.length-2,sentence.length);
    if(end == na) {
        return "Hit";
    }
    else {
        return "No hit";
    }
}

var result = lastTwo(sentence);
console.log(result);
