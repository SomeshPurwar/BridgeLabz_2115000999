const number = parseInt(process.argv[2], 10);

if (isNaN(number) || number < 0 || number > 9) {
    console.log("Please enter a single-digit number (0-9).");
} else if (number === 0) {
    console.log("Zero");
} else if (number === 1) {
    console.log("One");
} else if (number === 2) {
    console.log("Two");
} else if (number === 3) {
    console.log("Three");
} else if (number === 4) {
    console.log("Four");
} else if (number === 5) {
    console.log("Five");
} else if (number === 6) {
    console.log("Six");
} else if (number === 7) {
    console.log("Seven");
} else if (number === 8) {
    console.log("Eight");
} else if (number === 9) {
    console.log("Nine");
}
