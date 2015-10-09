//Problem 1. Odd or Even
//Write an expression that checks if given integer is odd or even

function isOdd(number) {
    if (number % 2 === 0) {
        return (number + ' is even');
    } else {
        return (number + ' is odd');
    }
}
// you can change the numbers to see for another results
console.log(isOdd(3));
console.log(isOdd(2));
console.log(isOdd(-2));
console.log(isOdd(-1));
console.log(isOdd(0));
