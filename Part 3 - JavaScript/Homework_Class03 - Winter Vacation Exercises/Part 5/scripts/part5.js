var flag = false;

function closerTo100() {
    var a = parseInt(prompt("Number 1:"));
    var b = parseInt(prompt("Number 2:"));
    if (a <= 0 || b <= 0) {
        alert("Negative number, try again.");
    }
    else {
        flag = true;
        if ((100-a) > (100-b)) {
            console.log("Number "+b+" is closer to 100.")
        }
        else if(a == b) {
            console.log("The numbers are equale.")
        }
        else {
            console.log("Number "+a+" is closer to 100.")
        }
    }
}


while(flag == false) {
    closerTo100();
}