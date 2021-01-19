var nameOfRecipe = prompt("Name of recipe:")
var numberOfIngredients = prompt("Number of ingredients:");
numberOfIngredients = parseInt(numberOfIngredients);

function yourRecipe(name, numIngredients) {
    let ing = [];
    let temp = "";

    for (let i = 0; i < numIngredients; i++) {
        temp = prompt("Ingredient number "+(i+1)+": ");
        ing.push(temp);
    }

    let body1 = document.getElementsByTagName("body")[0];
    let h1Recipe = document.createElement("h1");
    h1Recipe.innerText += nameOfRecipe;
    body1.appendChild(h1Recipe);

    return ing;
}


function createTable(arrayOfIng) {

    let body1 = document.getElementsByTagName("body")[0];
    let table1 = document.createElement("table");
    let tbody1 = document.createElement("tbody");
    
     for(var i = 0; i < arrayOfIng.length; i++) {
        let tr = document.createElement("tr");
        console.log(tr);
        table1.appendChild(tr);


        let td1 = document.createElement("td");
        tr.appendChild(td1);
        td1.innerText += "No."+(i+1);

        let td2 = document.createElement("td");
        tr.appendChild(td2);
        td2.innerText += arrayOfIng[i];
     }

    table1.setAttribute("border", "1");
    table1.appendChild(tbody1);
    body1.appendChild(table1);
}


function mainFunction(name, numIngredients) {

    let r = yourRecipe(name, numIngredients);
    createTable(r);
}

mainFunction(nameOfRecipe, numberOfIngredients);