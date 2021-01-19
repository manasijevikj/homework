var numbers = [5,3,6,11,8,24,1];
var sum = 0;
var mEquasion = "";

var myDiv =  document.getElementById("myDiv");

// List
var theList =  document.createElement("ul");
theList.style.listStyleType = "none";
myDiv.appendChild(theList);

// Paragraphs
var p1 = document.createElement("p");
myDiv.appendChild(p1);
var p2 = document.createElement("p");
myDiv.appendChild(p2);

for (let i = 0; i < numbers.length; i++) {
    let li = document.createElement("li");
    li.innerText += ""+numbers[i]+"";
    theList.appendChild(li);
    sum += numbers[i];
}

p1.innerText += `Sum of all of the numbers: ${sum}`;

for (let i = 0; i < numbers.length-1; i++) {
    mEquasion += ""+numbers[i]+"+";
}

mEquasion = mEquasion+""+numbers[numbers.length-1]+"="+sum;
p2.innerText += mEquasion;






