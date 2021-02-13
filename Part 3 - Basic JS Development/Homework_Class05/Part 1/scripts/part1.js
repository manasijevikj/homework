let firstH1 = document.getElementById("myTitle");
firstH1.innerText = "";
firstH1.innerText = "Hi there!";


let firstParagraph = document.getElementsByClassName("paragraph")[0];
firstParagraph.innerText = "";
firstParagraph.innerText = "is a greeting.";


let secondParagraph = document.getElementsByClassName("second")[0];
secondParagraph.innerText = "";
secondParagraph.innerText = "There refers to the position that the other person is in, so it is an adverb";


let texts = document.getElementsByTagName("text")[0]; 
texts.innerText = "";
texts.innerText = "It can also serve to attract attention.";


let lastDiv = document.getElementsByTagName("div")[2];
let children1 = lastDiv.firstElementChild;

children1.innerText = "";
children1.innerText = "Hi over there!";

let children2 = children1.nextElementSibling;
children2.innerText = "";
children2.innerText = "or Hello over there works the same way as Hi there or Hello there";


