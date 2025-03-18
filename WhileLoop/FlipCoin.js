let headsCount = 0;
let tailsCount = 0;

while (headsCount < 11 && tailsCount < 11) {
    let result = Math.random() < 0.5 ? "Heads" : "Tails"; 
    console.log(result);

    if (result === "Heads") {
        headsCount++;
    } else {
        tailsCount++;
    }
}

console.log(`\nGame Over! ${headsCount === 11 ? "Heads" : "Tails"} wins 11 times.`);
