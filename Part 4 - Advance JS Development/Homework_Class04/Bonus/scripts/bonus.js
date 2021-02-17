let numberInput = document.getElementById("inputNumber");
let buttonEnter = document.getElementById("enterButton");
let mainDiv = document.getElementById("mainDiv");
let h3Result = document.createElement("h3");
mainDiv.appendChild(h3Result);

let validation = number => {
    h3Result.innerText = "";

    if (!numberInput.value) {
        h3Result.innerText = "Empty field";
        console.log("Empty field");
        return false;
    }
    if (number == 0) {
        h3Result.innerText = "Number can't be zero";
        console.log("Number can't be zero");
        return false;
    }
    return true;
}

let factorial = num => {
    if (validation(num)) {
        if (num === 1) {
            return 1;
        }
        return num * factorial(num - 1);
    }
    else {
        return false;
    }
}

buttonEnter.addEventListener("click", () => {
    let n = parseInt(numberInput.value);
    if (factorial(n)) {
        h3Result.innerText = `Factorial of ${n} is ${factorial(n)}`;

    }
    numberInput.value = "";
})