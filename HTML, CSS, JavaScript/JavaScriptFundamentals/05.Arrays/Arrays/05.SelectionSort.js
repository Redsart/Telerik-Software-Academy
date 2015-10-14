//Problem 5. Selection sort
//Sorting an array means to arrange its elements in increasing order.
//Write a script to sort an array.
//Use the selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
var vurrMin,
    helper,
    i,
    j;
function sort(arr) {
    for (i = 0; i < arr.length; i+=1) {
        currMin = i;
        for (j = i + 1; j < arr.length; j+=1) {
            if (arr[currMin] > arr[j]) {
                currMin = j;
            }
        }
        helper = arr[i];
        arr[i] = arr[currMin];
        arr[currMin] = helper;
    }

    console.log(arr.join(', '));
}

sort([4, 3, 6, 8, 9, 2, 11, 0, -4, -2, 18]);