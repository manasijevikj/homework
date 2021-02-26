$(document).ready(function () {

    let home = $("#home");
    let task1 = $("#task1");
    let task2 = $("#task2");
    let task3 = $("#task3");
    let task4 = $("#task4");
    let task5 = $("#task5");
    let navItems = $(".nav-item");

    let header = $("#header");
    let message = $("#message")
    let table = $("#result");


    function Product(name, category, hasDiscount, price) {
        this.name = name;
        this.category = category;
        this.hasDiscount = hasDiscount;
        this.price = price;

    }

    let products = [new Product("Ice Cream", "Food", true, 2), new Product("Jacket", "Clothes", false, 35), new Product("Curtain", "Decor", true, 25), new Product("Lettuce", "Food", false, 1), new Product("Jeans", "Clothes", false, 22), new Product("My Lady Jane", "Books", true, 7), new Product("Eggs", "Food", false, 4), new Product("Apple", "Food", true, 1), new Product("Chess", "Games", true, 20), new Product("A Promised Land", "Books", true, 9), new Product("Speed Cube", "Games", false, 18), new Product("Monopoly", "Games", false, 21), new Product("Carpet", "Decor", true, 38), new Product("Almonds", "Food", false, 15), new Product("Emma", "Books", false, 10), new Product("Chair", "Decor", true, 26), new Product("Shelf", "Decor", true, 21)];


    function copyArray(array) {
        let copiedArr = [];
        array.forEach(i => copiedArr.push(i));
        return copiedArr;
    }

    function addAndRemoveClass(item, navItems) {
        for (let navItem of navItems) {
            $(navItem).removeClass("active");
        }
        item.addClass("active");
    }


    // function for creating tables

    function fullTable(result, numTask) {
        header.text("");
        table.html("");
        message.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-3">Name</div>
        <div class="col-md-3">Category</div>
        <div class="col-md-3">Discount</div>
        <div class="col-md-3">Price</div>

    </div>`);
        result.forEach(product => {
            table.append(`<div class="row">
            <div class="col-md-3">${product.name}</div>
            <div class="col-md-3">${product.category}</div>
            <div class="col-md-3">${product.hasDiscount}</div>
            <div class="col-md-3">${product.price}</div>
        </div>`)
        })
    }


    function nameTable(result, numTask) {
        header.text("");
        table.html("");
        message.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-6">Name</div>
        
    </div>`);
        result.forEach(product => {
            table.append(`<div class="row">
        <div class="col-md-6">${product}</div>

    </div>`)
        })
    }

    function nameAndPriceTable(result, numTask) {
        header.text("");
        table.html("");
        message.text("");
        header.text(`Task ${numTask}`);
        table.append(`<div class="row">
        <div class="col-md-6">Name and Price</div>
        
    </div>`);
        result.forEach(product => {
            table.append(`<div class="row">
        <div class="col-md-6">${product}</div>

    </div>`)
        })
    }


    //Listeners
    home.click(() => {
        header.text("");
        message.text("");
        table.html("");
        addAndRemoveClass(home, navItems);
    })

    task1.click(() => {
        let greaterThan20 = products.filter(product => product.price > 20);
        fullTable(greaterThan20, 1);
        message.text("All products with price greater than 20:");
        addAndRemoveClass(task1, navItems);
    })

    task2.click(() => {
        let foodOnDiscount = products.filter(product => product.hasDiscount && product.category == "Food").map(product => product.name);
        nameTable(foodOnDiscount, 2);
        message.text("Names of all products of Category Food, that are on discount:");
        addAndRemoveClass(task2, navItems);
    })


    task3.click(() => {
        message.text("");
        header.text("");
        table.html("");
        let averagePrice = products.filter(product => product.hasDiscount == true).map(product => product.price).reduce((avg, price, index) => (avg * index + price) / (index + 1), 0);
        header.text("Task 3");
        message.text(`The average price of all products that are on discount is: $${averagePrice.toFixed(2)}`);
        addAndRemoveClass(task3, navItems);
    })


    task4.click(() => {
        let notOnDiscount = products.filter(product => !product.hasDiscount).filter(product => {
            let vowels = ("aeiouAEIOU");
            for (let i of vowels) {
                if (product.name[0] === i) {
                    return product;
                }
            }
        }).map(product => `${product.name} --- ${product.price}`)
        nameAndPriceTable(notOnDiscount, 4);
        message.text("Name and price of all products with name starting with a vowel, that are not on discount:");
        addAndRemoveClass(task4, navItems);
    })

    task5.click(() => {
        let productsByPrice = copyArray(products);
        productsByPrice.sort((product1, product2) => product1.price - product2.price);
        fullTable(productsByPrice, 5);
        message.text("The products by price, ascending, without changing the original array:");
        addAndRemoveClass(task5, navItems);
    })

})





