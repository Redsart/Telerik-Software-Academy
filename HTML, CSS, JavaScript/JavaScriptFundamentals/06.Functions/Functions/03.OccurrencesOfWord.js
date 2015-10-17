//Problem 3. Occurrences of word
//Write a function that finds all the occurrences of word in a text.
//The search can be case sensitive or case insensitive.
//Use function overloading.

function countOccurrences(text, searchedWord, isCaseSensitive) {
    isCaseSensitive = isCaseSensitive || false;     // case sensitivity is turned off if value is not asigned to the parameter
    var substrings = text.split(searchedWord);
    return substrings.length - 1;
}

function printResult() {
    var text = 'This is text, not a Text, or like other text, this text is unique.';
    var searchedWord = 'text';
    console.log(countOccurrences(text, searchedWord, true));
}

printResult();