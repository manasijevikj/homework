function boysAndGirls(girls, boys) {
    if(girls < 10) {
        girls = "0"+girls;
    }
    if (boys < 10) {
        boys = "0"+boys;
    }

console.log("girls "+girls+", boys "+boys);
}


var g = prompt("Girls:");
g = parseInt(g);

var b = prompt("Boys:");
b = parseInt(b);

boysAndGirls(g,b);