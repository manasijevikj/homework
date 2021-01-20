function create_table()
{
    let nRows = document.getElementById("rows").value;
    let nCols = document.getElementById("cols").value;
    
    let newTable = document.createElement("table");
    newTable.setAttribute("border", "1");
    for(var i = 0; i < nRows; i++)
    {
            let newRow = document.createElement("tr");
            for(var j = 0; j < nCols; j++)
            {
                let newCol = document.createElement("td");
                newCol.innerText = "Row "+(i+1)+" Col "+(j+1);
                newRow.appendChild(newCol);
            }
        newTable.appendChild(newRow);
    }
    let myBody = document.getElementsByTagName("body")[0];
    myBody.appendChild(newTable);
}

let myButton = document.getElementById("button");
myButton.addEventListener("click", create_table);