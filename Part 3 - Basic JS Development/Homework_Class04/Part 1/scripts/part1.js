var newArray = ["Jana", "Happy", "Danncing"];

function tellStory(inputArray)  {
    let name = inputArray[0];
    let mood = inputArray[1];
    let activity = inputArray[2];
    let finalStorry = `This is ${name}. ${name} is a nice person. Today they are ${mood}. They are ${activity} all day. The end.`

    return finalStorry;
}

var theStory = tellStory(newArray);
console.log(theStory);