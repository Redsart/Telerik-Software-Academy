//Problem 2. Numbers not divisible
//Write a script that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time

var number = window.prompt(('Enter number: '));
    number *= 1;

for (var i = 1; i <= number; i++) {
    if (number % 21) {
        console.log(i);
    }
}