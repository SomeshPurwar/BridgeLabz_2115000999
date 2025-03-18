const num = parseInt(process.argv[2], 10);

if (isNaN(num) || num < 0) {
    console.log("Please enter a valid non-negative integer.");
} else {
    let factorial = 1;

    for (let i = 1; i <= num; i++) {
        factorial *= i;
    }

    console.log(`Factorial of ${num} is: ${factorial}`);
}
