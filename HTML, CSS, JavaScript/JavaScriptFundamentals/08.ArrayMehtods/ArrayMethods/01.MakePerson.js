//Problem 1. Make person

//Write a function for creating persons.
//Each person must have firstname, lastname, age and gender (true is female, false is male)
//    Generate an array with ten person with different names, ages and genders

function Person(firstName, lastName, age, gender) {
    this.firstName = firstName;
    this.lastName = lastName;
    this.age = age;
    this.gender = !gender ? 'male' : 'female';
}

var people=[
    new Person('Asen', 'Filipov', 23, false),
    new Person('Kiril', 'Kirilov', 26, false),
    new Person('Milena', 'Venkova', 27, true),
    new Person('Stefan', 'Toshev', 30, false),
    new Person('Aneliq', 'Georgieva', 24, true),
    new Person('Vencislav', 'Evlogiev', 26, false),
    new Person('Ivo', 'Mitev', 23, false),
    new Person('Ivan', 'Goshev', 29, false),
    new Person('Antonia', 'Georgieva', 28, true),
    new Person('Petar', 'Petrov', 21, false)
];

for (var person in people) {
    console.log(people[person]);
}