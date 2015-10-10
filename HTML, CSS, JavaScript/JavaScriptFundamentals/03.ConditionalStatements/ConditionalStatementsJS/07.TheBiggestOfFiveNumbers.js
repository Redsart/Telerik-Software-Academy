//Problem 7. The biggest of five numbers
//Write a script that finds the greatest of given 5 variables.
//Use nested if statements.

var numberA = window.prompt(('Enter number: ')),
    numberB = window.prompt(('Enter number: ')),
    numberC = window.prompt(('Enter number: ')),
    numberD = window.prompt(('Enter number: ')),
    numberE = window.prompt(('Enter number: '));

if (numberA > numberB && numberA > numberC && numberA > numberD && numberA > numberE) {
    alert('The biggest number is: ' + numberA);
} else if (numberB > numberA && numberB > numberC && numberB > numberD && numberB > numberE) {
    alert('The biggest number is: ' + numberB);
} else if (numberC > numberA && numberC > numberB && numberC > numberD && numberC > numberE) {
    alert('The biggest number is: ' + numberC);
} else if (numberD > numberA && numberD > numberB && numberD > numberC && numberD > numberE) {
    alert('The biggest number is: ' + numberD);
} else if (numberE > numberA && numberE > numberB && numberE > numberC && numberE > numberD) {
    alert('The biggest number is: ' + numberE);
}

