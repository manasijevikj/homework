var input = prompt("Insert the phrase:")

let animal = {
    name: "Bonnie",
    kind: "Dog",
    
    speak: function(phrase) {
        console.log(`${this.kind} ${this.name} says: ${phrase}`);
    }
}

animal.speak(input);

