//Problem 1. JavaScript literals
//Assign all the possible JavaScript literals to different variables.

//Problem 3. Typeof variables
//Try typeof on all variables you created.

//Problem 4. Typeof null
//Create null, undefined variables and try typeof on them.

var array = [1, 2, 3],
    anotherArray = ['Apple', 'Banana', 'Orange'],
    integer = 255,
    float = 255.55,
    hex = '7b',
    dec = '1100',
    boolean = isNaN(9),
    obj = { firstName: 'Ivan', lastName: 'Ivanov' },
    str = 'this is string',
    nullvalue = null,
    undefinedValue = undefined;

var variables = [array, anotherArray, integer, float, hex, dec, boolean, obj, str, nullvalue, undefinedValue];

for(var variable in variables){
    console.log(getTypeString(variables[variable]));
}

function getTypeString(obj) {
    var result = obj;
    result += ' is ' + typeof obj;
    return result;
}