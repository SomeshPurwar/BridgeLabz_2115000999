const n = parseInt(process.argv[2], 10);

if (isNaN(n) || n < 0) {
    console.log("Please enter a valid non-negative integer.");
} else {
    console.log(`Table of Powers of 2 up to 2^${n} (Max 256):`);

    let i = 0;
    let power = 1; 

    while (i <= n && power <= 256) {
        console.log(`2^${i} = ${power}`);
        i++;
        power *= 2; 
    }
}
