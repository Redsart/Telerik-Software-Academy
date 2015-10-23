//Problem 2. Remove elements
//Write a function that removes all elements with a given value.
//Attach it to the array type.
//Read about prototype and how to attach methods.

function removeElement(array, element) {
    for (var index = 0; index < array.length; index++) {
        if (array[index] === element) {
            array.splice(index, 1);
            --index;
        }
    }
}

var arr = [1, 2, 1, 4, 1, 3, 4, 1, 111, 3, 2, 1, '1'];

console.log(arr);
removeElement(arr, 1);
console.log(arr);

