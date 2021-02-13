function concatenateStrings(inputArray) {
    let finalString = "";

    for (let i = 0; i < inputArray.length; i++) {
        finalString = finalString+(inputArray[i]+" ");
    }

    console.log(finalString);
}

concatenateStrings(["JavaScript","is","as","related","to","Java","as","Carnival","is","to","Car."]);

