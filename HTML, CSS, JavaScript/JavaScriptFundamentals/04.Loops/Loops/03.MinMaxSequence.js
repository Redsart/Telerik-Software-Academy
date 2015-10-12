//Problem 3. Min/Max of sequence
//Write a script that finds the max and min number from a sequence of numbers.

var numbers = [23704, 15663, 25617, 32111, 49211, 59091, 6891, 40822, 60321, 18954, 72685, 8429, 19829, 30222,
    51123, 42345, 35471, 32337, 5196, 11125, 21354, 23073, 3477, 11639, 59347, 60993, 53912, 78323, 96588, 9584],
	minInd = 0,
	maxInd = 0;

for (var ind = 0; ind < numbers.length; ind++) {
    if (numbers[maxInd] < numbers[ind]) maxInd = ind;
    if (numbers[ind] < numbers[minInd]) minInd = ind;
}

console.log('min: ' + numbers[minInd]);
console.log('max: ' + numbers[maxInd]);