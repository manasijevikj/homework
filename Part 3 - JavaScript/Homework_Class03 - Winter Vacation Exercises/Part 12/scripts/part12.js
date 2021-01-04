function grade() {
    var g = prompt("Insert your grade");
    g = g.toUpperCase();

    console.log(g);

    switch (g) {
        case "A":
            console.log("Excellent job!");
            break;

        case "B":
            console.log("Good job!");
            break; 
            
        case "C":
            console.log("Passed");
            break;   
    
        case "D":
            console.log("Not so Good!");
            break;

        case "F":
            console.log("Failed!");
            break;

        default:
            console.log("Unknown grade!")
            break;
    }
}

grade();