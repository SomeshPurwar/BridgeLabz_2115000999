const num = parseInt(process.argv[2], 10);

if (isNaN(num) || num < 2) {
    console.log("Please enter a valid number greater than or equal to 2.");
} else {
    let n = num;
    console.log(`Prime factors of ${num} are:`);

    for (let i = 0; n % 2 === 0; i++) {
        console.log(2);
        n = n / 2;
    }

    
    for (let i = 3; i * i <= n; i += 2) {
        for (let j = 0; n % i === 0; j++) {
            console.log(i);
            n = n / i;
        }
    }

    if (n > 2) {
        console.log(n);
    }
}
