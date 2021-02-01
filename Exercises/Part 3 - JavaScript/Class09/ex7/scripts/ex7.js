$(document).ready(function() {

    let num = $("#inNumber");
    let but1= $("#button1");
    let but2 = $("#button2");
    let but3 = $("#button3");
    let h3 = $("h3");
    let circle;

    function Circle(radius) {
        this.radius = radius

        this.getArea = function() {
            let res1 = (this.radius*this.radius)*Math.PI;
            return res1;
        }

        this.getPerimeter = function() {
            let res2 = 2*this.radius*Math.PI;
            return res2;
        }
    }


    but1.click(function() {
        if(!!num.val()) {
            h3.text("");
            h3.text("The Circle is created");
            circle = new Circle(num.val());
        }
        else {
            h3.text("");
            h3.text("Insert the radius");
        }

    })

    but2.click(function() {
        h3.text("");
        h3.text(circle.getArea());
    })


    but3.click(function() {
        h3.text("");
        h3.text(circle.getPerimeter());
    })


})