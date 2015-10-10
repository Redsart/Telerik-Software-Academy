//Problem 1. Exchange if greater
//Write an if statement that takes two double variables a and b and exchanges their values if the first one is greater than the second.
//As a result print the values a and b, separated by a space.

function greater(firstNumber, secondNumber) {
    if (firstNumber < secondNumber) {
        return (firstNumber + ' ' + secondNumber);
    } else if (firstNumber > secondNumber) {
        return (secondNumber + ' ' + firstNumber);
    } else {
        return ('Nummers are equals');
    }
}

console.log(greater(5, 2));
console.log(greater(3, 4));
console.log(greater(5.5, 4.5));