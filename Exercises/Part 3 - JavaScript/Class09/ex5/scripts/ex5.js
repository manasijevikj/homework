$(document).ready(function(){

    let text1 = $("#inputV");
    let buttonS = $("#buttonS");
    let select = $(".selectClass");

    buttonS.click(function() {

        if(!!text1.val()) {
            let valueT = text1.val();
            select.append(`<option value="${valueT}">${valueT}</option>`)
        }
    })

    text1.blur(function() {
        if(!text1.val()) {
            alert("Empty text field")
        }
    })

});
