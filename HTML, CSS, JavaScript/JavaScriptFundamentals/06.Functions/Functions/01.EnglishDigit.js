//Problem 1. English digit
//Write a function that returns the last digit of given integer as an English word.

function englishDigit(number) {
    lastDigit = number % 10;
    switch (lastDigit) {
        case 0: console.log('Zero'); break;
        case 1: console.log('One'); break;
        case 2: console.log('Two'); break;
        case 3: console.log('Three'); break;
        case 4: console.log('Four'); break;
        case 5: console.log('Five'); break;
        case 6: console.log('Six'); break;
        case 7: console.log('Seven'); break;
        case 8: console.log('Eight'); break;
        case 9: console.log('Nine'); break;
    }
}

englishDigit(512);
englishDigit(1024);
englishDigit(12309);