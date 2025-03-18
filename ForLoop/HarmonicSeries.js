const n = parseInt(process.argv[2], 10);

if (isNaN(n) || n <= 0) {
    console.log("Please enter a valid positive integer.");
} else {
    let harmonic = 0;

    for (let i = 1; i <= n; i++) {
        harmonic += 1 / i;
    }

    console.log(`\nThe ${n}th harmonic number (H(${n})) is: ${harmonic.toFixed(6)}`);
}
