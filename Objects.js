// let user = new Object(); // "object constructor" syntax
// let users = {};  // "object literal" syntax
// console.log(typeof(user));
// console.log(typeof(users));

// let user = {     // an object
//     name: "John",  // by key "name" store value "John"
//     age: 30        // by key "age" store value 30
// };

// console.log(user);


// console.log(user.name);
// console.log(user.age);
// delete user.age;
// console.log(user);

let user = {
    name: "John",
    age: 30,
    "likes birds": true  // multiword property name must be quoted
};

// this would give a syntax error
// user.likes birds = true;

user["likes birds"] = false;
console.log(user);




