var sentence = prompt("Write something..");
var vowels = "aeiouAEIOU"; // also I can use Array
var flag = false;



function hit(a) {
    let x = a.substring(0,1);
    let newSentence;

    for(var i = 0; i <= 9; i++) {
        if (vowels.substring(i,i+1) == x ) {
            flag = true;
        }
    }

    if (flag == true) {
        newSentence = "Hit "+sentence+" Hit";
        return newSentence;
    }
    else {
        return sentence;
    }
}


var s = hit(sentence);
console.log(s);