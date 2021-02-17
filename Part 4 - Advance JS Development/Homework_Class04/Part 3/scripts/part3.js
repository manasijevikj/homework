let names = ["Sanja", 4, "Jasmina", "Angela", "Nikola"];
let surNames = ["Angelova", "Atanasova", "Kamceva", "Ristevska", "Bozinov"];


let validation = (arrNam, arrSurNam) => {
    if (arrNam.length != 5 || arrSurNam.length != 5) {
        console.log("You don't have 5 names or 5 surnames");
        return false;
    }

    for (let i = 0; i < 5; i++) {
        if (typeof (arrNam[i]) !== "string" || typeof (arrSurNam[i]) !== "string") {
            console.log("Some of your names or surnames is not string");
            return false;
        }
    }
    return true;
}

let fullName = ((arrayNames, arraySurnames) => {
    if (validation(arrayNames, arraySurnames)) {
        for (let i = 0; i < 5; i++) {
            console.log(`${arrayNames[i]} ${arraySurnames[i]}`);
        }
    }
})(names, surNames);




