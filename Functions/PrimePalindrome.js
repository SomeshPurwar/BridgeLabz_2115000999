function isPrime(num) {
    if (num < 2) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

function getPalindrome(num) {
    return parseInt(num.toString().split('').reverse().join(''));
}

function checkPrimeAndPalindrome(num) {
    if (isPrime(num)) {
        let palindrome = getPalindrome(num);
        if (isPrime(palindrome)) {
            return `${num} is prime and its palindrome ${palindrome} is also prime.`;
        } else {
            return `${num} is prime but its palindrome ${palindrome} is not prime.`;
        }
    } else {
        return `${num} is not a prime number.`;
    }
}
