function arePalindromes(num1, num2) {
    function isPalindrome(num) {
        const str = num.toString();
        return str === str.split('').reverse().join('');
    }
    return isPalindrome(num1) && isPalindrome(num2);
}

console.log(arePalindromes(121, 131)); 
console.log(arePalindromes(123, 454)); 