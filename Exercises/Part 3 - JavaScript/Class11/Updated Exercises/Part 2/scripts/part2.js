$(document).ready(function () {

    let account;
    let pin = $("#pin");
    let button1 =$("#button1");
    let h3 = $("h3");

    let value = $("#value").hide();
    let button2 = $("#button2").hide();
    let button3 =$("#button3").hide();
    let button4 =$("#button4").hide();

    function Account(pin) {
    this.pin = pin;
    this.balance = Math.floor(Math.random() * 10000);;

        this.deposit = function(amount) {
            this.balance += parseInt(amount);
        }

        this.withdrawal = function(amount) {
            if(this.balance < amount) {
                return false;
            }
            this.balance -= parseInt(amount);
            return true;
        }
    }


    button1.click(function() {

        if(!pin.val()) {
            h3.text("Pin not inserted");
            return;
        }

        h3.text("");
        account = new Account(pin.val());

        value.show();
        button2.show();
        button3.show();
        button4.show();

        pin.hide();
        button1.hide();
    })


    button2.click(function() {

        if(!value.val()) {
            h3.text("Amount not inserted");
            return;
        }

        h3.text("");
        account.deposit(value.val());
        h3.text(`Your account balance: ${account.balance}`);
    })


    button3.click(function() {

        if(!value.val()) {
            h3.text("Amount not inserted");
            return;
        }
        h3.text("");

        let temp = account.withdrawal(value.val());
        if(!temp) {
            h3.text(`You don't have enough money`);
        }
        else {
            h3.text("");
            h3.text(`Your account balance: ${account.balance}`);
        }
    })


    button4.click(function() {
        h3.text(`Your account balance: ${account.balance}`);
    })

})