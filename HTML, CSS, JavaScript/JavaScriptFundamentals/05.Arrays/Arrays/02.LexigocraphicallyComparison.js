//Problem 2. Lexicographically comparison
//Write a script that compares two char arrays lexicographically (letter by letter).

function compare(n, m) {
    var firstArray = randomString(n),
        secondArray = randomString(m),
        len = Math.min(firstArray.length, secondArray.length),
        i;

    if (firstArray < secondArray) {
        console.log('Second array has a bigger lenght');
    } else if (firstArray === secondArray) {
        for (i = 0; i < len; i+=1) {
            if (firstArray[i] > secondArray[i]) {
                console.log('First array has a bigger lenght');
            } else if (firstArray[i] < secondArray[i]) {
                console.log('Second array has a bigger lenght');
            } else {
                console.log('Arrays are equals');
            }
        }
    }
}

function randomString(len) {
    var chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXTZabcdefghiklmnopqrstuvwxyz";
    var randomStr = '';
    for (var i = 0; i < len; i++) {
        var rndNum = Math.floor(Math.random() * chars.length);
        randomStr += chars.substring(rndNum, rndNum + 1);
    }

    return randomStr;
}

compare(21, 32);
compare(22, 16);
compare(19, 19);