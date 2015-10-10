//Problem 6. Quadratic equation
//Write a script that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
//Calculates and prints its real roots.
//Note: Quadratic equations may have 0, 1 or 2 real roots.

var a = window.prompt(('Enter coeficient a:')),
    b = window.prompt(('Enter coeficient b:')),
    c = window.prompt(('Enter coeficient c:'));

var discriminant = (b * b) - (4 * a * c);
var firstRoot = (-b - Math.sqrt(discriminant)) / (2 * a);
var secondRoot = (-b + Math.sqrt(discriminant)) / (2 * a);
if (discriminant>0)
{ 
    alert('x1= ' + firstRoot + '; ' + 'x2= ' + secondRoot);
} else
{
    alert("No real roots!");
}