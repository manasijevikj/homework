$(document).ready(function () {

    let navItems = $(".nav-item");
    let home = $("#home");
    let task1 = $("#task1");
    let task2 = $("#task2");
    let cardContainer = $("#cardContainer");


    function Person(id, firstName, lastName, age) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;

        this.getFullName = function () {
            return `${this.firstName} ${this.lastName}`
        }
    }

    function Animal(name, age) {
        this.name = name;
        this.age = age;

        this.eat = function () {
            return `The cat is eating now`;
        }

        this.sleap = function () {
            return `The cat is sleaping now`;
        }
    }

    function colorGenerate() {
        let colors = ["Bela", "Crna", "Siva", "Portokalova", "Kafeava"];
        let num = Math.floor(Math.random() * 5);
        return colors[num];
    }

    function Cat(name, age, ownerId) {
        Object.setPrototypeOf(this, new Animal(name, age));
        this.color = colorGenerate();
        this.ownerId = ownerId === undefined ? null : ownerId;

        this.meow = function () {
            return `The cat ${this.name} says: <strong>Meow</strong>`;
        }

        this.ownerDetails = function (peopleArray) {
            if (this.ownerId === null) {
                return `The cat does not have owner`;
            }

            let result = peopleArray.filter(person => person.id === this.ownerId);
            return result;
        }
    }


    function PersianCat(name, age, ownerId, eyeColor) {
        Object.setPrototypeOf(this, new Cat(name, age, ownerId));
        this.eyeColor = typeof (eyeColor) !== "string" ? "unknown" : eyeColor;


        this.furDescription = function () {
            return `The cat ${this.name} has full fur!`;
        }
    }

    function RagDollCat(name, age, ownerId, weight, isFriendly) {
        Object.setPrototypeOf(this, new Cat(name, age, ownerId));
        this.weight = weight;
        this.isFriendly = isFriendly;


        this.printPersonality = function (type) {
            if (typeof (type) !== "boolean") {
                return `You have to enter a boolean value!`;
            }
            else {
                if (!type) {
                    this.isFriendly = false;
                    return `The cat is not friendly!`;
                }
                this.isFriendly = true;
                return `The cat is friendly!`;

            }
        }
    }

    function addAndRemoveClass(item, navItems) {
        for (let navItem of navItems) {
            $(navItem).removeClass("active");
        }
        item.addClass("active");
    }

    //Home
    home.click(() => {
        cardContainer.html("");
        addAndRemoveClass(home, navItems);
    })


    //Task 1

    let people = [new Person(1, "Ana", "Janeva", 27), new Person(2, "Stefan", "Milevski", 33), new Person(3, "Marija", "Koceva", 20),
    new Person(4, "Sandra", "Blazevska", 23), new Person(5, "Simon", "Boshkovski", 40)];

    let cat1 = new Cat("Mici", 4, 3);
    let cat2 = new Cat("Leo", 7, 4);


    function catCard(cat) {
        cardContainer.append(`<div class="col mb-4">
        <div class="card">
            <img src="images/cat.png" alt="Cat">
            <div class="card-body">
                <h5 class="card-title"></h5>
                <p class="card-text">Name: ${cat.name}</p>
                <p class="card-text">Age: ${cat.age}</p>
                <p class="card-text">Color: ${cat.color}</p>
                <p class="card-text">Owner ID: ${cat.ownerId}</p>
                <a href="#" class="btn btn-primary" id="meowBtn${cat.ownerId}">Meow</a>
                <div id="divMeow${cat.ownerId}"></div>
            </div>
            <div class="card-footer">
                <small class="text-muted">More info about cats <a href="https://en.wikipedia.org/wiki/Cat"
                        target="_blank">Wikipedia</a></small>
            </div>
        </div>
    </div>`);

        $(`#meowBtn${cat.ownerId}`).click(function () {
            $(`#divMeow${cat.ownerId}`).html("");
            $(`#divMeow${cat.ownerId}`).append(`
            <div class="alert alert-primary" role="alert"> ${cat.meow()}
            </div>`)
        });

    }

    task1.click(function () {
        cardContainer.html("");
        addAndRemoveClass(task1, navItems);
        catCard(cat1);
        catCard(cat2);
    })


    //Task2

    let persianCat = new PersianCat("Charli", 2, 1, "Crna");
    let ragDollCat = new RagDollCat("Lili", 1, 5, 7, true);


    function catCard3(cat) {
        cardContainer.append(`<div class="col mb-4">
        <div class="card">
            <img src="images/cat.png" alt="Cat">
            <div class="card-body">
                <h5 class="card-title"></h5>
                <p class="card-text">Name: ${cat.name}</p>
                <p class="card-text">Age: ${cat.age}</p>
                <p class="card-text">Color: ${cat.color}</p>
                <p class="card-text">Owner ID: ${cat.ownerId}</p>
                <p class="card-text">Eye color: ${cat.eyeColor}</p>
                <a href="#" class="btn btn-primary" id="furBtn${cat.ownerId}">Fur Description</a>
                <div id="divFur${cat.ownerId}"></div>
                <hr class="my-4">
                <a href="#" class="btn btn-primary" id="ownerBtn${cat.ownerId}">Owner Details</a>
                <div id="divOwner${cat.ownerId}"></div>
            </div>
            <div class="card-footer">
                <small class="text-muted">More info about cats <a href="https://en.wikipedia.org/wiki/Cat"
                        target="_blank">Wikipedia</a></small>
            </div>
        </div>
    </div>`);

        // ownerDetails function
        let person = cat.ownerDetails(people);

        $(`#furBtn${cat.ownerId}`).click(function () {
            $(`#divFur${cat.ownerId}`).html("");
            $(`#divFur${cat.ownerId}`).append(`
            <div class="alert alert-primary" role="alert"> ${cat.furDescription()}
            </div>`)
        });

        $(`#ownerBtn${cat.ownerId}`).click(function () {
            $(`#divOwner${cat.ownerId}`).html("");
            $(`#divOwner${cat.ownerId}`).append(`
            <p class="card-text">Owner ID: ${person[0].id}</p>
            <p class="card-text">First Name: ${person[0].firstName}</p>
            <p class="card-text">Last Name: ${person[0].lastName}</p>
            <p class="card-text">Age: ${person[0].age}</p>
            `)
        });
    }


    function catCard4(cat) {
        cardContainer.append(`<div class="col mb-4">
        <div class="card">
            <img src="images/cat.png" alt="Cat">
            <div class="card-body">
                <h5 class="card-title"></h5>
                <p class="card-text">Name: ${cat.name}</p>
                <p class="card-text">Age: ${cat.age}</p>
                <p class="card-text">Color: ${cat.color}</p>
                <p class="card-text">Owner ID: ${cat.ownerId}</p>
                <p class="card-text">Weight: ${cat.weight}</p>
                <p class="card-text">Is Friendly: ${cat.isFriendly}</p>
                <a href="#" class="btn btn-primary" id="personalityBtn${cat.ownerId}">Print Personality</a>
                <div id="divPersonality${cat.ownerId}"></div>
                <hr class="my-4">
                <a href="#" class="btn btn-primary" id="ownerBtn${cat.ownerId}">Owner Details</a>
                <div id="divOwner${cat.ownerId}"></div>
            </div>
            <div class="card-footer">
                <small class="text-muted">More info about cats <a href="https://en.wikipedia.org/wiki/Cat"
                        target="_blank">Wikipedia</a></small>
            </div>
        </div>
    </div>`);

        // ownerDetails function
        let person = cat.ownerDetails(people);

        $(`#personalityBtn${cat.ownerId}`).click(function () {
            $(`#divPersonality${cat.ownerId}`).html("");
            $(`#divPersonality${cat.ownerId}`).append(`
            <div class="alert alert-primary" role="alert"> ${cat.printPersonality(true)}
            </div>`)
        });

        $(`#ownerBtn${cat.ownerId}`).click(function () {
            $(`#divOwner${cat.ownerId}`).html("");
            $(`#divOwner${cat.ownerId}`).append(`
            <p class="card-text">Owner ID: ${person[0].id}</p>
            <p class="card-text">First Name: ${person[0].firstName}</p>
            <p class="card-text">Last Name: ${person[0].lastName}</p>
            <p class="card-text">Age: ${person[0].age}</p>
            `)
        });
    }

    task2.click(function () {
        cardContainer.html("");
        addAndRemoveClass(task2, navItems);
        catCard3(persianCat);
        catCard4(ragDollCat);
    })


})