let tbody = document.getElementsByTagName("tbody")[0];

function insert_Row() {
    let nbRows = document.getElementsByTagName("tr").length;

    let tr = document.createElement("tr");
    tbody.appendChild(tr);
    nbRows++;

    let td1 =  document.createElement("td");
    td1.innerText = `Row${nbRows} cell1`;
    tr.appendChild(td1);

    let td2 =  document.createElement("td");
    td2.innerText = `Row${nbRows} cell2`;
    tr.appendChild(td2);
}