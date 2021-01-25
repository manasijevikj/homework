function valuesInserted() {
    var title = document.getElementById("title").value;
    var author = document.getElementById("author").value;
    var readingStatus = document.getElementsByName("status");
    var r = true;
    
    if (readingStatus[0].checked) {
        r = true;
    }
    else {
        r = false;
    }

    var book = new BookReadingStatus(title, author, r);
    book.reading();
}


function BookReadingStatus(title, author, readingStatus) {
    this.title = title;
    this.author = author;
    this.readingStatus= readingStatus;

    this.reading = function() {

        if (this.readingStatus == true) {
            console.log(`Already read ${this.title} by ${this.author}`);
        }
        else {
            console.log(`You still need to read ${this.title} by ${this.author}`);
        }
    }
}

var button =  document.getElementById("buttonS");

button.addEventListener("click", valuesInserted);




