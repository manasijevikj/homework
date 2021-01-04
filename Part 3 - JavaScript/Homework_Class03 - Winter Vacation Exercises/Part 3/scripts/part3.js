var width = parseInt(prompt("Width of rectangle:"));
var height = parseInt(prompt("Height of rectangle:"));

function perimeter(a,b) {
    let per = 2*(width+height);
    console.log("Perimeter of rectangle is: "+per);
} 

perimeter(width,height);