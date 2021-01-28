$(document).ready(function() {
    let cont =$("#content");
    let options = $("option");
    let button = $("input")

    $("#myColor").change(function() {
        let selectedOption =  $("#myColor option:selected");

        cont.text(selectedOption.val());
        cont.css("color", selectedOption.val());
    })

    button.click(function() {
        options.remove();
        $("#myColor").append(`<option value="Orange" id="newOption" >Orange</option>`);
        let orangeOption = $("#newOption");
        cont.text(orangeOption.val());
        cont.css("color", orangeOption.val());
    })
})