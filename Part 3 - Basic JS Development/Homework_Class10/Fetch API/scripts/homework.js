let idNum = document.getElementById("idNum");
let button1 = document.getElementById("button1");
let h3 = document.getElementsByTagName("h3")[0];
let ul = document.getElementsByTagName("ul")[0];


button1.addEventListener("click", function() {
    fetch("https://jsonplaceholder.typicode.com/todos")
    .then(response => {
        response.json()
        .then(data => {
            h3.innerText ="";
            if(!idNum.value || idNum.value <=0 || idNum.value > 200) {
                h3.innerText ="Not Completed";
                while (ul.firstChild) {
                    ul.firstChild.remove();
                }
            }
            else {
                let li = document.createElement("li");
                li.innerText =`ID:${data[idNum.value-1].id} - Title: ${data[idNum.value-1].title}`;
                ul.append(li);
                h3.innerText ="Completed";
            }
        })
        .catch(err=>{
            console.log(err);
        });
    });

});



