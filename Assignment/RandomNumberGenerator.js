function getRandomNumber() {
    return Math.floor(Math.random() * 900) + 100; 
}

function findSecondLargestAndSmallest(arr) {
    let largest = -Infinity, secondLargest = -Infinity;
    let smallest = Infinity, secondSmallest = Infinity;

    for (let num of arr) {
        if (num > largest) {
            secondLargest = largest;
            largest = num;
        } else if (num > secondLargest && num !== largest) {
            secondLargest = num;
        }

        if (num < smallest) {
            secondSmallest = smallest;
            smallest = num;
        } else if (num < secondSmallest && num !== smallest) {
            secondSmallest = num;
        }
    }

    return { secondLargest, secondSmallest };
}

let randomNumbers = Array.from({ length: 10 }, getRandomNumber);
console.log("Generated Numbers:", randomNumbers);

let { secondLargest, secondSmallest } = findSecondLargestAndSmallest(randomNumbers);
console.log("Second Largest:", secondLargest);
console.log("Second Smallest:", secondSmallest);
