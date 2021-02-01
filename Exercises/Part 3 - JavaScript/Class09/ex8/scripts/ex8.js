$(document).ready(function() {

    function Person (fullName, job, salary) {
        this.fullName = fullName;
        this.job = job;
        this.salary = salary;
    }

    function sumOfSalaries(persons) {
        let sum = 0;
        for(let i of persons) {
            sum += i.salary;
        }
        return sum;
    }

    var parsonsArray = [new Person("Aleksandar Manasijevikj","Web Developer",26000), new Person("Marija Ivanova","Web Designer",24000),new Person("Bojan Stefanovski","Taxi Driver",20000)];
    var result = sumOfSalaries(parsonsArray);
    console.log(result);
})