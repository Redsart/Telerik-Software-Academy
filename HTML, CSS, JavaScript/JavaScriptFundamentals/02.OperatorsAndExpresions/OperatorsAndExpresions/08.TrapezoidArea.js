//Problem 8. Trapezoid area
//Write an expression that calculates trapezoid's area by given sides a and b and height h.

function area(a, b, h) {
    var result = (0.5 * h * (a + b));
    return ('a=' + a + ' b=' + b + ' h=' + h + '\n' + 'The area of trapezoid is: ' + result);
}

console.log(area(5, 7, 12));
console.log(area(2, 1, 33));
console.log(area(8.5, 4.3, 2.7));
console.log(area(100, 200, 300));
console.log(area(0.222, 0.333, 0.555));