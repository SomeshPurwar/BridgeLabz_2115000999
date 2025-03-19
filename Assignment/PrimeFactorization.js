function getPrimeFactors(n) {
    let factors = [];
    
    while (n % 2 === 0) {
        factors.push(2);
        n = Math.floor(n / 2);
    }

    for (let i = 3; i * i <= n; i += 2) {
        while (n % i === 0) {
            factors.push(i);
            n = Math.floor(n / i);
        }
    }

    if (n > 2) {
        factors.push(n);
    }

    return factors;
}

let num = 315; 
let primeFactors = getPrimeFactors(num);

console.log(`Prime factors of ${num}:`, primeFactors);
