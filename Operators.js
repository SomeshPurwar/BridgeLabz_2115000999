// Unary
// let x = 1;

// x = -x;
// console.log( x ); // -1, unary negation was applied

// Binary
let x = 1, y = 3;
console.log( y - x ); // 2, binary minus subtracts values
console.log(5 % 2 ); // 1, the remainder of 5 divided by 2
console.log(2 ** 3); // 2³ = 8

console.log(4 ** (1/2)); // 2 (power of 1/2 is the same as a square root)

console.log("my" + "string"); // mystring

console.log('1' + 2); // "12"

console.log(2 + 2 + '1' ); // "41" and not "221"

console.log('1' + 2 + 2); // "122" and not "14"
console.log(6 - '2'); // 4, converts '2' to a number
console.log('6' / '2'); // 3, converts both operands to numbers

// Numeric conversion, unary +

console.log(+true);  // 1
console.log(+"" ); //0

let apples = "2";
let oranges = "3";

// both values converted to numbers before the binary plus
console.log( +apples + +oranges ); // 5
