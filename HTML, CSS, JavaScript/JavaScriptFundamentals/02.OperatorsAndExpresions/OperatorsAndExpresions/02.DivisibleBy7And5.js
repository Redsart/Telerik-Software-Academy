//Problem 2. Divisible by 7 and 5
//Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.

function isDivisible(number){
    if(number%7==0 && number%5==0){
        return (number + ' is divisible by 5 and 7');
    }
    else{
        return (number + ' is not divisible by 5 and 7');
    }
}

console.log(isDivisible(3));
console.log(isDivisible(0));
console.log(isDivisible(5));
console.log(isDivisible(7));
console.log(isDivisible(35));
console.log(isDivisible(140));