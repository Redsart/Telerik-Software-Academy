//Problem 9. Point in Circle and outside Rectangle
//Write an expression that checks for given point P(x, y) if it is within the circle K( (1,1), 3) and out of the rectangle R(top=1, left=-1, width=6, height=2).

radius = 3;

function pointPosition(x, y) {
    if (((x - 1) * (x - 1) + (y - 1) * (y)) <= (radius * radius) && ((x < -1) || (x > 5) || (y > 1) || (y < -1))) {
        return ('The point with coordinates: x=' + x + ' y=' + y + ' is inside the circle and outside of rectangle');
    } else {
        return ('The point with coordinates: x=' + x + ' y=' + y + ' is not inside the circle and outside of rectangle');
    }
}

console.log(pointPosition(1, 4));
console.log(pointPosition(3, 2));
console.log(pointPosition(0, 1));
console.log(pointPosition(4, 1));
console.log(pointPosition(2, 0));
console.log(pointPosition(4, 0));
console.log(pointPosition(2.5, 1.5));
console.log(pointPosition(3.5, 1.5));
console.log(pointPosition(-100, -100));
