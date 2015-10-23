//Problem 4. Has property
//Write a function that checks if a given object contains a given property.

var cat = {
    name: 'Hana',
    color: 'White',
    gender: 'Female'
};

console.log(cat);
console.log('has name: ' + hasProperty(cat, 'name'));
console.log('has breed: ' + hasProperty(cat, 'breed'));
cat.breed = 'Unknown';
console.log(cat);
console.log('has breed: ' + hasProperty(cat, 'breed'));

function hasProperty(obj, prop) {
        return obj.hasOwnProperty(prop);
}