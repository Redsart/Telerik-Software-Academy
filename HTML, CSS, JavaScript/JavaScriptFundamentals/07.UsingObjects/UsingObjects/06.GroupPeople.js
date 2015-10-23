//Problem 6.
//Write a function that groups an array of people by age, first or last name.
//The function must return an associative array, with keys - the groups, and values - arrays with people in this groups
//Use function overloading (i.e. just one function)

function Person(firstName, lastName, age) {
    if(isNaN(age) || !isFinite(age)){
        throw new Error('Age must be number');
    }

    if(!(this instanceof Person)){
        return new Person(firsName, lastName, age);
    }

    this.firstName=firstName;
    this.lastName=lastName;
    this.age=age;
}

Person.prototype.toString=function(){
    return '(' + this.firstName + ' ' + this.lastName + ' ' + this.age + ')';
}

var people=[
    new Person('Ivan', 'Nikolov', 23),
    new Person('Stefan', 'Dimitrov', 20),
    new Person('Georgi', 'Iliev', 25),
    new Person('Milena', 'Stamenova', 22),
    new Person('Albena', 'Todorova', 25)
];

function group(arr, prop){
    var group=[];
    for (var index in arr){
        var currentProp=arr[index][prop];
        group[currentProp]=group[currentProp] || [];
        group[currentProp].push(arr[index]);
    }
    return group;
}

function printGroups(prop, arr){
    console.log(prop);
    for(var key in arr){
        console.log(arr[key].join('; '));
    }
    console.log();
}

var props=['firsName', 'lastName', 'age'];

for(var index in props){
    var groups=group(people, props[index]);
    printGroups(props[index], groups)
}