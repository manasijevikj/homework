$(document).ready(function () {

    let libForm = $("#libForm").hide();
    let bookForm = $("#bookForm").hide();
    let authorForm = $("#authorForm").hide();

    let home = $("#home");
    let libraryTasks = $("#libraryTasks");
    let bookTasks = $("#bookTasks");
    let authorTasks = $("#authorTasks");
    let navItems = $(".nav-item");


    function Library(name, books, address) {
        this.name = name;
        this.books = books === undefined ? [] : books;
        this.address = address;

        this.numberOfMembers = function () {
            if (this.books.length === 0) {
                return "No Books in the library";
            }
            if (this.books.length > 0) {
                return this.books.length * 15;
            }
        }

        this.printBooks = function () {
            let text;
            let temp;
            if (this.books.length === 0) {
                return "No Books in the library";
            }
            else {
                temp = "";
                this.books.forEach(book => temp += book.title + "; ")
                return temp;
            }

        }
        this.addBook = function (book) {
            let newBook = Object.create(book);
            this.books.push(newBook);
        }
    }

    function Book(title, genre, libraries, authors) {
        this.title = title;
        this.genre = genre;
        this.libraries = libraries === undefined ? [] : libraries;
        this.authors = authors === undefined ? [] : authors;

        this.addLibrary = function (library) {
            this.libraries.push(library);
            library.addBook(this);
        }


        this.removeLibrary = function (library) {
            this.libraries = this.libraries.filter(lib => JSON.stringify(lib) !== JSON.stringify(library));
            library.books = library.books.filter(book => JSON.stringify(book) !== JSON.stringify(this));
        }

        this.showLibraries = function () {
            if (this.libraries.length === 0) {
                return "There are no Libraries"
            }
            temp = "";
            this.libraries.forEach(lib => temp += lib.name + "; ")
            return temp;
        }
    }

    function Author(firstName, lastName, yearOfBirth) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.yearOfBirth = yearOfBirth;
        this.books = [];
        this.currentBook = null;

        this.startBook = function (book) {
            this.currentBook = book;
            this.books.push(book);
        }

        this.showBooks = function () {
            if (this.books.length === 0) {
                return "There are no Books"
            }
            temp = "";
            this.books.forEach(book => temp += book.title + "; ")
            return temp;
        }
    }

    function addAndRemoveClass(item, navItems) {
        for (let navItem of navItems) {
            $(navItem).removeClass("active");
        }
        item.addClass("active");
    }


    let book1 = new Book("The Great Gatsby", "Fiction");
    let book2 = new Book("The Handmaid's Tale", "Dystopia");
    let book3 = new Book("Animal Farm", "Allegory");
    let book4 = new Book("1984", "Dystopia");
    let book5 = new Book("The Stand", " Fantasy fiction");
    let book6 = new Book("The Green Mile", "Fantasy");

    let library1 = new Library("New York Public Library", [book1, book2, book3, book6], "New York");
    let library2 = new Library("Bodleian Library", [book2, book4, book5], "Oxford");
    let library3 = new Library("National Library of China", [book3, book4, book6], "Beijing");

    let author1 = new Author("Stephen", "King", "1947");


    //Home
    home.click(() => {
        libForm.hide();
        bookForm.hide();
        authorForm.hide();
        addAndRemoveClass(home, navItems);
    })

    //Library
    libraryTasks.click(function () {
        libForm.show();
        bookForm.hide();
        authorForm.hide();
        addAndRemoveClass(libraryTasks, navItems);
    })
    //Number Of Members
    $("#lib1").click(function () {
        $("#h3lib1").text(`Number Of Members: ${library1.numberOfMembers()}`);
    })
    //Print Books
    $("#lib2").click(function () {
        $("#h3lib2").text(`Books in library: ${library1.printBooks()}`);
        library1.printBooks();
    })
    //Add Book
    $("#lib3").click(function () {
        $("#h3lib3").text(`The book "The Stand" is added`);
        library1.addBook(book5);
    })

    //------------------------

    //Book
    bookTasks.click(function () {
        bookForm.show();
        libForm.hide();
        authorForm.hide();
        book1.addLibrary(library3);
        addAndRemoveClass(bookTasks, navItems);
    })


    //Add Library
    $("#book1").click(function () {
        $("#h3book1").text(`Bodleian Library is added to The Great Gatsby`);
        book1.addLibrary(library2);
    })

    //Remove Library
    $("#book2").click(function () {
        $("#h3book2").text(`Bodleian Library is removed from The Great Gatsby`);
        book1.removeLibrary(library2);
    })

    //Show Libraries
    $("#book3").click(function () {
        $("#h3book3").text(`${book1.showLibraries()}`);
        book1.showLibraries();
    })


    //------------------------

    //Author
    authorTasks.click(function () {
        authorForm.show();
        bookForm.hide();
        libForm.hide();
        author1.startBook(book3);
        addAndRemoveClass(authorTasks, navItems);
    })

    //Start Book
    $("#author1").click(function () {
        $("#h3author1").text(`George Orwell starts "1984" book`);
        author1.startBook(book4);
    })

    //Show Books
    $("#author2").click(function () {
        $("#h3author2").text(`George Orwell books: ${author1.showBooks()}`);
        author1.showBooks();
    })

})