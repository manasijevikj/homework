$(document).ready(function() {

    let n1 = $("#number1");
    let n2 = $("#number2");
    let n3 = $("#number3");
    let h1 = $("h1");
    let inputs = $("input");
    let avg;


    inputs.blur(function() {
        
        n1Value = parseInt(n1.val());
        n2Value = parseInt(n2.val());
        n3Value = parseInt(n3.val());

        if (!!n1Value && !!n2Value && !!n3Value) {
            avg = (n1Value+n2Value+n3Value)/3;
            h1.text(avg);
        }

    })

})