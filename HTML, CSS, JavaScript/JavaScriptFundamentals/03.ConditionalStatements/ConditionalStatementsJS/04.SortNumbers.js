//Problem 4. Sort 3 numbers
//Sort 3 real values in descending order.
//Use nested if statements.
//    Note: Don’t use arrays and the built-in sorting functionality.

var first = 0,
    second = 0,
    third = 0;

function sortedNumbers(a, b, c) {
    if (a >= b) {
        if (a >= c) {
            first = a;
            if (b >= c) {
                second = b;
                third = c;
            } else {
                second = c;
                third = b;
            }
        } else {
            first = c;
            second = a;
            third = b;
        }
    } else {
        if (b >= c) {
            first = b;
            if (a >= c) {
                second = a;
                third = c;
            } else {
                second = c;
                third = a;
            }
        } else {
            first = c;
            second = b;
            third = a;
        }
    }
    return (first + ' ' + second + ' ' + third);
}

console.log(sortedNumbers(5, 1, 2));
console.log(sortedNumbers(-2, -2, 1));
console.log(sortedNumbers(-2, 4, 3));
console.log(sortedNumbers(0, -2.5, 5));
console.log(sortedNumbers(-1.1, -0.5, -0.1));
console.log(sortedNumbers(10, 20, 30));
console.log(sortedNumbers(1, 1, 1));
