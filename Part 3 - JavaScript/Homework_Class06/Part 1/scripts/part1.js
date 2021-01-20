var fName = document.getElementsByTagName("input")[0];
var lName = document.getElementsByTagName("input")[1];
var button = document.getElementsByTagName("input")[2];
var myDiv = document.getElementById("content");

function checkNames(fn,ln) {
    let sFN = fName.value.length;
    let sLN = lName.value.length;

    if (fn <= sFN || ln <= sLN ) {
        myDiv.innerText = "Incorrect length";
    }
    else {
        myDiv.innerText += `Hello ${fName.value} ${lName.value}`;
    }
    
}

button.addEventListener("click", function() {
    checkNames(10,12);
})

myDiv.addEventListener("mouseover", function(event) {
    event.target.innerText = "";
})


