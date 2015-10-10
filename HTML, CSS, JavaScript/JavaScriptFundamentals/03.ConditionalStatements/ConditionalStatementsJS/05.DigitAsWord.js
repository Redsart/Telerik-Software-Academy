//Problem 5. Digit as word
//Write a script that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English).
//Print “not a digit” in case of invalid input.
//Use a switch statement.

var digit = window.prompt();
    digit *=1;

    switch (digit) {
        case 0: alert('zero'); break;
        case 1: alert('one'); break;
        case 2: alert('two'); break;
        case 3: alert('three'); break;
        case 4: alert('four'); break;
        case 5: alert('five'); break;
        case 6: alert('six'); break;
        case 7: alert('seven'); break;
        case 8: alert('eight'); break;
        case 9: alert('nine'); break;
        default: alert('not a digit');
    }
