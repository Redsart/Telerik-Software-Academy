//Problem 2. People of age

//Write a function that checks if an array of person contains only people of age (with age 18 or greater)
//    Use only array methods and no regular loops (for, while)

function Person(firstName, lastName, age, gender) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = !gender ? 'male' : 'female';
}

var people = [
    new Person('Asen', 'Filipov', 23, false),
    new Person('Kiril', 'Kirilov', 16, false),
    new Person('Milena', 'Venkova', 27, true),
    new Person('Stefan', 'Toshev', 30, false),
    new Person('Aneliq', 'Georgieva', 24, true),
    new Person('Vencislav', 'Evlogiev', 17, false),
    new Person('Ivo', 'Mitev', 23, false),
    new Person('Ivan', 'Goshev', 29, false),
    new Person('Antonia', 'Georgieva', 28, true),
    new Person('Petar', 'Petrov', 17, false)
];

var isAllAdult = people.every(function (item) {

    return item.age >= 18;
});

console.log('Is everyone over 18 years old? ' + isAllAdult);