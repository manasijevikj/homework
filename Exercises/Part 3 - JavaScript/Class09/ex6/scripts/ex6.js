let side1 = document.getElementById("input1");
let side2 = document.getElementById("input2");
let buttonS = document.getElementById("buttonS");
let par = document.getElementsByTagName("p")[0];


buttonS.addEventListener("click", function(){

    if(side1.value.length == 0 || side2.value.length == 0) {
        par.innerText = "Empty field"
    }
    else {
        let area = (side1.value)*(side2.value);
        par.innerText = `${area}`;
    }
})

par.addEventListener("mouseover", function(){

    if(side1.value.length == 0 || side2.value.length == 0) {
        par.innerText = "Empty field"
    } 
    else {
        console.log(par.innerText);
        par.style.color = "red";
        par.style.fontSize = "30px";
    }
})

