//Problem 2. Reverse number
//Write a function that reverses the digits of given decimal number.

function reverseNumber(number) {
    var reversed = number.toString().split("").reverse().join("");
    return console.log(reversed);
}

reverseNumber(256);
reverseNumber(123.45);


