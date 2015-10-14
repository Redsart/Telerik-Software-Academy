//Problem 6. Most frequent number
//Write a script that finds the most frequent number in an array.

function mostFrequentNumber(arr) {
    var maxL = 0,
        element = arr[0],
        i,
        j;
    for (i = 0; i < arr.length; i+=1) {
        var currL = 0;
        for (j = 0; j < arr.length; j+=1) {
            if (arr[i] === arr[j]) {
                currL++;
            }
        }

        if (currL > maxL) {
            maxL = currL;
            element = arr[i];
        }
    }

    console.log('Most frequent number: ' + element);
}

mostFrequentNumber([4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3]);