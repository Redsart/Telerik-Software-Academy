//Problem 1. Planar coordinates
//Write functions for working with shapes in standard Planar coordinate system.
//Points are represented by coordinates P(X, Y)
//Lines are represented by two points, marking their beginning and ending L(P1(X1,Y1), P2(X2,Y2))
//Calculate the distance between two points.
//Check if three segment lines can form a triangle.

function isNumber(n) {
    return isNaN(parseFloat(n)) && !isFinite(n);
}

function Point(x, y) {
    if (!isNumber(x) || !isNumber(y)) {
        console.log('Points must be numbers.')
    }

    if(!(this instanceof Point)){
        return new Point(x, y);
    }
    this.x = x;
    this.y = y;
}

Point.prototype.toString=function(){
    return 'P(' + this.x + ', ' + this.y + ')';
};

function Line(sPoint, ePoint) {
    if (!(sPoint instanceof Point) || !(ePoint instanceof Point)) {
        return 'sPoint and ePoint must be instance of Point';
    }

    if (!(this instanceof Line)) {
        return new Line(sPoint, ePoint);
    }
    this.sPoint = sPoint;
    this.ePoint = ePoint;
}

Line.prototype.getDistance = function () {
    var x = (this.sPoint.x - this.ePoint.x) * (this.sPoint.x - this.ePoint.x);
    var y = (this.sPoint.y - this.ePoint.y) * (this.sPoint.y - this.ePoint.y);
    return Math.sqrt(x + y);
};

Line.prototype.toString = function () {
    return 'P[' + this.sPoint.toString() + ',' + this.ePoint.toString() + ']';
};

function Triangle(a, b, c) {
    if (!(a instanceof Line) || !(b instanceof Line) || !(c instanceof Line)) {
        return 'a, b and c must be instances of Line';
    }

    if (!(this instanceof Triangle)) {
        return new Triangle(a, b, c);
    }

    if(!(canFormTriangle(a, b, c))){
        return 'Cant form Triangle';
    }
    this.a = a;
    this.b = b;
    this.c = c;
}

function canFormTriangle(a, b, c) {
    return a.getDistance() < b.getDistance() + c.getDistance() &&
           b.getDistance() < c.getDistance() + a.getDistance() &&
           c.getDistance() < a.getDistance() + b.getDistance();
}

var pointA = (2, 3),
    pointB = (3, 5),
    pointC = (6, 8),
    lineA = new Line(pointA, pointB),
    lineB = new Line(pointB, pointC),
    lineC = new Line(pointA, pointC),
    triagle = new Triangle(lineA, lineB, lineC);

console.log('PointA: ' + pointA.toString());
console.log('PointB: ' + pointB.toString());
console.log('PointC: ' + pointC.toString());
console.log('LineA: ' + lineA.toString());
console.log('LineB: ' + lineB.toString());
console.log('LineC: ' + lineC.toString());
console.log('Can form triangle from LineA, LineB, LineC? ' + canFormTriangle(lineA, lineB, lineC));