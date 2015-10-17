//Problem 7. First larger than neighbours
//Write a function that returns the index of the first element in array that is larger than its neighbours or -1, if there’s no such element.
//Use the function from the previous exercise.

function isLarger(arr) {
        var hasfound = false;
        for (i = 0; i < arr.length; i += 1) {
        if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1]) {
            hasfound = true;
            return i;
        }
        }
        if (!hasfound) {
            return -1;
        }
}

function testA(){
    var arr = [1, 2, 3, 4, 2];
    console.log(isLarger(arr));
}

function testB() {
    var arr = [1, 2, 3, 4, 5];
    console.log(isLarger(arr));
}

function testC() {
    var arr = [1, 2, 4, 3, 5];
    console.log(isLarger(arr));
}

testA();
testB();
testC();