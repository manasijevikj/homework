function Pet (name, type, age, isHealthy, owner) {
    this.name = name;
    this.type = type;
    this.age = age;
    this.isHealthy = isHealthy;
    this.owner = owner;

    this.isAdopted = function() {
        if(owner) {
            return true;
        }
        else{
            return false;
        }
    }
}


function Person(firstName, lastName, age) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

var pets = [(new Pet("Riki","Papagal",3,true, new Person("Bojan", "Trajkovski",34))), (new Pet("Mici","Macka",6,true,new Person("Marija", "Ivanova",24))), (new Pet("Lea","Kuce",12,false, new Person("Bojan", "Trajkovski",34)))];

var buttonS = document.getElementById("butonS");
buttonS.addEventListener("click", function() {

    let owner1 = document.getElementById("fName").value;

    for(let i of pets) {
        if(owner1 === pets[i].owner.firstName) {
            console.log(`${pets[i]}`);
        }
    }


}) 

