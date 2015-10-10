//Problem 2. Multiplication Sign
//Write a script that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

function sign(a, b, c) {
    if (a === 0 || b === 0 || c === 0) {
        return '0';
    } else if (a > 0 && b > 0 && c > 0) {
        return '+';
    } else if (a < 0 && b < 0 && c > 0) {
        return '+';
    } else if (a > 0 && b < 0 && c < 0) {
        return '+';
    } else if (a < 0 && b > 0 && c < 0) {
        return '+';
    } else if (a < 0 && b < 0 && c < 0) {
        return '-';
    } else if (a < 0 && b > 0 && c > 0) {
        return '-';
    } else if (a > 0 && b < 0 && c > 0) {
        return '-';
    } else if (a > 0 && b > 0 && c < 0) {
        return '-';
    }
}

console.log(sign(5, 2, 2));
console.log(sign(-2, -2, 1));
console.log(sign(-2, 4, 3));
console.log(sign(0, -2.5, 4));
console.log(sign(-1, -0.5, -5.1));
