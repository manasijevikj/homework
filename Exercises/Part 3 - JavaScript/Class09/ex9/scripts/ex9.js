$(document).ready(function () {
    let nameOwner = $("#fName");
    let button1 = $("#button1");

    function Pet(name, type, age, isHealthy, owner) {
        this.name = name;
        this.type = type;
        this.age = age;
        this.isHealthy = isHealthy;
        this.owner = owner;

        this.isAdopted = function () {
            if (!!owner) {
                return true;
            }
            else {
                return false;
            }
        }
    }

    function Person(firstName, lastName, age) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;

        this.printOwner = function () {
            console.log(`First Name: ${this.firstName}`);
            console.log(`Last Name: ${this.lastName}`);
            console.log(`Age: ${this.age}`);

            if (this.hasOwnProperty("pets")) {
                console.log("Pets:");
                for(let i = 0; i < this.pets.length; i++) {
                    console.log(`No.${i+1} - ${this.pets[i].name}`);
                }
            }
        }
    }


    var petsArray = [new Pet("Riki", "Papagal", 3, true, "Bojan"), new Pet("Mici", "Macka", 6, true, "Marija"), new Pet("Lea", "Kuce", 12, false, "Bojan"), new Pet("Lajka", "Kuce", 1, true, "Sara"), new Pet("Nemo", "Riba", 2, true, "Marija")];
    var people = [new Person("Joana", "Taleska", 25), new Person("Marija", "Jovanova", 35), new Person("Bojan", "Ivanovski", 25)];

    button1.click(function () {

        let nameOwnerValue = nameOwner.val().toLowerCase();
        let petOwner;
        

        if (!nameOwnerValue) {
            console.log("Your text field is empty");
            return;
        }

        for (let i = 0; i < people.length; i++) {
            if (nameOwnerValue == people[i].firstName.toLowerCase()) {
                petOwner = people[i];
                break;
            }
        }

        if (!petOwner) {
            console.log("This owner doesn't exist");
            return;
        }

        petOwner.pets = [];

        for (let i = 0; i < petsArray.length; i++) {
            if (petsArray[i].owner.toLowerCase() == petOwner.firstName.toLowerCase()) {
                petOwner.pets.push(petsArray[i]);
            }
        }

        petOwner.printOwner();
    })
})