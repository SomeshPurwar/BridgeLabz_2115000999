let num1 = Math.floor(Math.random() * 900) + 100;
let num2 = Math.floor(Math.random() * 900) + 100;
let num3 = Math.floor(Math.random() * 900) + 100;
let num4 = Math.floor(Math.random() * 900) + 100;
let num5 = Math.floor(Math.random() * 900) + 100;

console.log("Generated numbers:", num1, num2, num3, num4, num5);

let minValue = num1;
let maxValue = num1;

if (num2 < minValue) minValue = num2;
if (num3 < minValue) minValue = num3;
if (num4 < minValue) minValue = num4;
if (num5 < minValue) minValue = num5;

if (num2 > maxValue) maxValue = num2;
if (num3 > maxValue) maxValue = num3;
if (num4 > maxValue) maxValue = num4;
if (num5 > maxValue) maxValue = num5;

console.log("Minimum value:", minValue);
console.log("Maximum value:", maxValue);
