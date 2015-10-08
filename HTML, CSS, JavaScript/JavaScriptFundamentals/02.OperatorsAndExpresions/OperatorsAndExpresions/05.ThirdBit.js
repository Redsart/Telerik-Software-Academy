//Problem 5. Third bit
//Write a boolean expression for finding if the bit #3 (counting from 0) of a given integer.
//The bits are counted from right to left, starting from bit #0.
//The result of the expression should be either 1 or 0.

function getByte(number, position) {
    thirdBit = (number >> position) & 1;
    binaryNumber = number.toString(2);
    return ('number: ' + number + '\n' + 'binary representation: ' + binaryNumber+ '\n' + '#3 bit: ' + thirdBit);
}

console.log(getByte(5, 3));
console.log(getByte(8, 3));
console.log(getByte(0, 3));
console.log(getByte(15, 3));
console.log(getByte(5343, 3));
console.log(getByte(62241, 3));