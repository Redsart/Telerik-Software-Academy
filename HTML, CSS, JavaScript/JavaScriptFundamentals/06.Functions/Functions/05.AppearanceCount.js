//Problem 5. Appearance count
//Write a function that counts how many times given number appears in given array.
//Write a test function to check if the function is working correctly.

function appearanceCount(arr, number) {
    var answer = 0;
    arr.forEach(function (element) {
        if (element === number) {
            answer += 1;
        }
    });
    return answer;
}

function testA() {
    var arr=[1, 2, 3, 1, 3, 1, 4, 4, 2],
        number=2;
    console.log(appearanceCount(arr, number));
}

function testB() {
    var arr = [1, 2, 3, 1, 3, 1, 4, 4, 2, 3],
        number = 3;
    console.log(appearanceCount(arr, number));
}

function testC() {
    var arr = [1, 4, 3, 1, 3, 1, 4, 4, 2],
        number = 4;
    console.log(appearanceCount(arr, number));
}

testA();
testB();
testC();
