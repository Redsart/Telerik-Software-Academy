//Problem 4. Number of elements
//Write a function to count the number of div elements on the web page

function countDivs() {
    return document.getElementsByTagName('div');
}

console.log(countDivs());