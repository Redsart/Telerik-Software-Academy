//Problem 4. Maximal increasing sequence
//Write a script that finds the maximal increasing sequence in an array.

function maxIncreasingSequence(arr) {
    var currentL = 1,
        maxL = 0,
        lastIndex = 0,
        i,
        j;
    for (i = 1; i < arr.length; i+=1) {
        if (arr[i - 1] < arr[i]) {
            currentL++;
        }
        else {
            if (maxL < currentL) {
                maxL = currentL;
                currentL = 1;
                lastIndex = i;
            }
        }
    }

    if (maxL < currentL) {
        maxL = currentL;
        lastIndex = arr.length;
    }

    var resultsStr = "Maximal increasing sequence : ";
    for (j = 0; j < maxL; j+=1) {
        resultsStr += arr[lastIndex - maxL + j];
        resultsStr += ' ';
    }

    console.log(resultsStr);
}

maxIncreasingSequence([3, 2, 3, 4, 2, 2, 4, 5, 6, 7]);