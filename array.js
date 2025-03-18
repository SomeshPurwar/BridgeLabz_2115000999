// let arr = new Array(); // Array Initialization
// arr[0]=10,arr[1]=20;
// console.log(arr);

let arr1 = []; // Array Initialization
arr1[0]=10,arr1[1]=20;
console.log(arr1);

let fruits = ["Apple", "Orange", "Plum"];
console.log( fruits[0] ); // Apple
console.log( fruits[1] ); // Orange
console.log( fruits[2] ); // Plum

fruits[2] = 'Pear'; // now ["Apple", "Orange", "Pear"]

fruits[3] = 'Lemon'; // now ["Apple", "Orange", "Pear", "Lemon"]
console.log(fruits);
console.log(fruits.length); //4

let arr = [ 'Apple', { name: 'John' }, true, function() { console.log('hello'); } ];
arr[3](); //hello

console.log(fruits[fruits.length-1]);
console.log(fruits.at(-1));
console.log(fruits.pop()); //Extracts the last element of the array and returns it
console.log(fruits);
fruits.push("Lemon"); // Append the element to the end of the array
console.log(fruits);

console.log(fruits.shift()); //Extracts the first element of the array and returns it
console.log(fruits);
fruits.unshift('Apple'); //Add the element to the beginning of the array
console.log(fruits);

let fruit = ["Banana"]

let arrr = fruit; // copy by reference (two variables reference the same array)

console.log( arrr === fruit ); // true

arrr.push("Pear"); // modify the array by reference

console.log( fruit ); // Banana, Pear - 2 items now
console.log(String(fruits));



