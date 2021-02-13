var account = 50;
var money;
var flag = false;


function withdrawal(money) {
    if((account-money) <0)
    {
        console.log("Not enough money.");
        console.log("You have "+account+" denars on your account.");
    }
    else {
        account -= money;
        console.log("You withdrawal "+money+" denars, and you have "+account+" denars left.")
    }
}

function deposit(money) {
    account += money;
    console.log("You add "+money+" to your account, and now you have "+account+" denars.")
}

function checking () {
    console.log("You have "+account+" denars left.")
}

function again() {
    if(flag == false)
    {
        var next = prompt("1.For Continue insert 1. \n2.For Exit insert 2");
        next = parseInt(next);
    
        if(next == 1) {
            atm();
        }
        else if(next == 2) {
            console.log("Bye")
            flag = true;
        }
    }
}


function atm() {
    let option = prompt("1.For Withdrawal insert 1 \n2.For Deposit insert 2 \n3.For Checking your account insert 3.")
    option = parseInt(option);


    if (option == 1) {
        money = prompt("Amount of money:");
        money = parseFloat(money);
        withdrawal(money);
        again();
    }

    else if(option ==2) {
        money = prompt("Amount of money:");
        money = parseFloat(money);
        deposit(money);
        again();
    }

    else if(option == 3) {
        checking();
        again();
    }

    else {
        console.log("Error...")
    }
}

atm();



