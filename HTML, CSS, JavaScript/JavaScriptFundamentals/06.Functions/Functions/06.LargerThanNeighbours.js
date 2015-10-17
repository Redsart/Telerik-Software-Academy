//Problem 6. Larger than neighbours
//Write a function that checks if the element at given position in given array of integers is bigger than its two neighbours (when such exist).

function isLarger(arr, pos) {
    if (pos <= 0 || pos >= arr.length) {
        console.log('Please chose another position.');
    }
    else {
        if (arr[pos] > arr[pos - 1] && arr[pos] > arr[pos + 1]) {
            console.log(true);
        }
        else {
            console.log(false);
        }
    }
}

function testA() {
    var arr = [1, 2, 3, 4, 2],
        pos = 3;
    console.log(isLarger(arr, pos));
}

function testB() {
    var arr = [1, 2, 3, 4, 5],
        pos = 3;
    console.log(isLarger(arr, pos));
}

function testC() {
    var arr = [1, 2, 3, 4, 2],
        pos = 5;
    console.log(isLarger(arr, pos));
}

testA();
testB();
testC();