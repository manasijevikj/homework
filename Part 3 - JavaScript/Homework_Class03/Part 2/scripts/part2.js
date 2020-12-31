var a = 2;
var b = "Hi";
var c = false;
var d = null;
var e;

function fun1(x) {
console.log("Value: "+x)
console.log("Type of value "+x+": "+typeof(x));

return x; //I don't need it 
}

fun1(a);
fun1(b);
fun1(c);
fun1(d);
fun1(e);