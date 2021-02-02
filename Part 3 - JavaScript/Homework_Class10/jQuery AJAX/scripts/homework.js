$(document).ready(function () {
    let idNum = $("#idNum");
    let h3 = $("h3");
    let ul = $("ul");

    $("#button1").click(function () {
        $.ajax({
            url: "https://jsonplaceholder.typicode.com/todos",
            success: function (result) {

                h3.text("")
                if(!idNum.val() || idNum.val() <=0 || idNum.val() > 200) {
                    h3.text("Not Completed");
                    ul.empty();
                }
                else{
                    ul.append(`<li> ID:${result[idNum.val()-1].id} - Title: ${result[idNum.val()-1].title}</li>`);
                    h3.text("Completed");
                }
            },
            error: function(err){
                console.log(err);
            }
        });
    });
})