//Problem 5. Youngest person
//Write a function that finds the youngest person in a given array of people and prints his/hers full name
//Each person has properties firstname, lastname and age.

function Person(firstName, lastName, age) {
    if (isNaN(age) || !isFinite(age)) {
        throw new Error('Age mus be number.');
    }
    if (!(this instanceof Person)) {
        return new Person(firstName, lastName, age);
    }

    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
}

Person.prototype.toString = function () {
    return this.firstName + ' ' + this.lastName;
}

function comparePeople(a, b) {
    return a.age - b.age;
}

var people = [
    new Person('Gosho', 'Petrov', 32),
    new Person('Bay', 'Ivan', 81)
];

people.sort(comparePeople);

for (var person = 0; person < people.length; person++) {
    console.log(people[person]);
}

console.log('Youngest: ' + people[0].toString());