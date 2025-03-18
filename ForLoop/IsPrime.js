const num = parseInt(process.argv[2], 10);

if (isNaN(num) || num < 2) {
    console.log("Please enter a valid number greater than or equal to 2.");
} else {
    let isPrime = true;

    for (let i = 2; i * i <= num; i++) {
        if (num % i === 0) {
            isPrime = false;
            break;
        }
    }

    if (isPrime) {
        console.log(`${num} is a Prime Number.`);
    } else {
        console.log(`${num} is NOT a Prime Number.`);
    }
}
