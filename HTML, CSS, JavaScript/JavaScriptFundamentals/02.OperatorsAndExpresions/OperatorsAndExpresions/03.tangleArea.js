//Problem 3. Rectangle area
//Write an expression that calculates rectangle’s area by given width and height.

function area(a, b) {
    var result = a * b;
    return ('a=' + a + ' b=' + b + '\n' + 'The area of rectangle is: ' + result);
}

console.log(area(3, 4));
console.log(area(2.5, 3));
console.log(area(5, 5));