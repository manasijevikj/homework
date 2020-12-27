var year = prompt("Birth year:")
year = parseInt(year);
year = (year -4) % 12;



if(year == 0)
{
    alert("Rat")
}

else if(year == 1)
{
    alert("Ox")
}

else if(year == 2)
{
    alert("Tiger")
}

else if(year == 3)
{
    alert("Rabbit")
}

else if(year == 4)
{
    alert("Dragon")
}

else if(year == 5)
{
    alert("Snake")
}

else if(year == 6)
{
    alert("Horse")
}

else if(year == 7)
{
    alert("Goat")
}

else if(year == 8)
{
    alert("Monkey")
}

else if(year == 9)
{
    alert("Rooster")
}

else if(year == 10)
{
    alert("Dog")
}

else
{
    alert("Pig")
}

// also Switch Case can be used
