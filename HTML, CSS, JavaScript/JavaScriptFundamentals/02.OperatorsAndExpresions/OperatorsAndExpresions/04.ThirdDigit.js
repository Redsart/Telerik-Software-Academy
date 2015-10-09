//Problem 4. Third digit
//Write an expression that checks for given integer if its third digit (right-to-left) is 7.

function thirdDigitisSeven(number) {
    if((Math.floor(number/100)%10==7)){
        return (number + '- third digit is 7');
    } else {
        return (number + '- third digit is not 7');
    }
}

console.log(thirdDigitisSeven(5));
console.log(thirdDigitisSeven(701));
console.log(thirdDigitisSeven(1732));
console.log(thirdDigitisSeven(9703));
console.log(thirdDigitisSeven(877));
console.log(thirdDigitisSeven(777877));
console.log(thirdDigitisSeven(9999799));