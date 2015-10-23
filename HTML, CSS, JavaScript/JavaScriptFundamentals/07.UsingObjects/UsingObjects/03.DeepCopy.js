//Problem 3. Deep copy
//Write a function that makes a deep copy of an object.
//The function should work for both primitive and reference types.

console.log(clone(3));
console.log(clone({ car: 'Opel', model: 'Vectra' }));

function clone(obj) {
    if (typeof obj !== 'object') {
        return obj;
    }

    var cloned = {};
    for (var prop in obj) {
        cloned[prop] = clone(obj[prop]);
    }
    return cloned;
}

