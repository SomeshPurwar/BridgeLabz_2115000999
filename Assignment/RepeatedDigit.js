function findRepeatedDigitNumbers() {
    let repeatedNumbers = [];

    for (let i = 10; i < 100; i++) {
        let tens = Math.floor(i / 10);
        let ones = i % 10;

        if (tens === ones) {
            repeatedNumbers.push(i);
        }
    }

    return repeatedNumbers;
}

let result = findRepeatedDigitNumbers();
console.log("Numbers with repeated digits:", result);
