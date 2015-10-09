//Problem 6. Point in Circle
//Write an expression that checks if given point P(x, y) is within a circle K({0,0}, 5). //{0,0} is the centre and 5 is the radius


var radius=5;

function pointInCircle(x, y) {
    if ((x * x + y * y) <= radius * radius) {
        return ('The point with positions: x=' + x + ' y=' + y + ' - is inside the circle');
    } else {
        return ('The point with positions: x=' + x + ' y=' + y + ' - is outside the circle');
    }
}

console.log(pointInCircle(0, 1));
console.log(pointInCircle(-5, 0));
console.log(pointInCircle(-4, 5));
console.log(pointInCircle(1.5, -3));
console.log(pointInCircle(-4, -3.5));
console.log(pointInCircle(100, -30));
console.log(pointInCircle(0, 0));
console.log(pointInCircle(0.2, -0.8));
console.log(pointInCircle(0.9, -4.93));
console.log(pointInCircle(2, 2.655));