alert("Insert five different numbers and print the maximum number.")
var max = -Infinity;
var num;
for(var i=0; i<=4; i++)
{
    num = prompt("Value of number "+(i+1));
    num = parseInt(num);
    if(num > max) 
    {
        max = num;
    }
}
alert("Maximum number: "+max);