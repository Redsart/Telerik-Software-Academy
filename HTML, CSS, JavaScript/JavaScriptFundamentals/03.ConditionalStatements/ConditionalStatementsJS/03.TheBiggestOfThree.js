//Problem 3. The biggest of Three
//Write a script that finds the biggest of three numbers.
//Use nested if statements.

function greaterOfThree(a, b, c) {
    if (a >= b && a >= c) {
        return ('The biggest number is: ' + a);
    } else if (b >= a && b >= c) {
        return ('The biggest number is: ' + b);
    } else if (c >= a && c >= b) {
        return ('The biggest number is: ' + c)
    }
}

console.log(greaterOfThree(5, 2, 2));
console.log(greaterOfThree(-2, -2, 1));
console.log(greaterOfThree(-2, 4, 3));
console.log(greaterOfThree(0, -2.5, 5));
console.log(greaterOfThree(-0.1, -0.5, -1.1));