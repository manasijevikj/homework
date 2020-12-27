var price = prompt("Price:");
var tax = prompt("Tax rate:");
tax = tax/100;
tax = tax*price;
price = price + tax;
var res = price*30;
alert("The price of 30 phones is "+res);
