function oneTo20() {
    var rule1 ="\n";
    var rule2 = " ";
    var result = "";
    for(let i = 1; i <= 20; i++) {
        result += i;
        if(i%2 == 0){
            result += rule1;
        }
        else {
            result += rule2;
        }
    }
    console.log(result);
}

oneTo20();