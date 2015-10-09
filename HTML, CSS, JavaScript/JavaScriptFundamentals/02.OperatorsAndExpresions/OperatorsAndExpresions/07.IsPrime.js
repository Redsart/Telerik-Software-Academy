//Problem 7. Is prime
//Write an expression that checks if given positive integer number n (n ≤ 100) is prime.


function isPrime(number) {
    if (number >= 0 && number < 101) {
        if (number == 2 || number == 3 || number == 5 || number == 7) {
            return (number + ' is prime');
        } else if (number % 2 != 0 && number % 3 != 0 && number % 5 != 0 && number % 7 != 0) {
            return (number + ' is prime');
        } else {
            return (number + ' is not prime');
        }
    } else {
        return (number + ' must be ≤ 100');
    }
}

console.log(isPrime(1));
console.log(isPrime(2));
console.log(isPrime(3));
console.log(isPrime(4));
console.log(isPrime(9));
console.log(isPrime(37));
console.log(isPrime(97));
console.log(isPrime(51));
console.log(isPrime(-3));
console.log(isPrime(0));