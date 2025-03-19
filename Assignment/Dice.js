function rollDie() {
    return Math.floor(Math.random() * 6) + 1;
}

function simulateDiceRolls() {
    let rollCounts = new Map(Array.from({ length: 6 }, (_, i) => [i + 1, 0]));

    let maxReached = false;
    while (!maxReached) {
        let roll = rollDie();
        rollCounts.set(roll, rollCounts.get(roll) + 1);

        if (rollCounts.get(roll) === 10) maxReached = true;
    }

    console.log("Final Roll Counts:", Object.fromEntries(rollCounts));

    let sortedRolls = [...rollCounts.entries()].sort((a, b) => a[1] - b[1]);
    console.log(`Number that reached maximum times: ${sortedRolls[5][0]} (${sortedRolls[5][1]} times)`);
    console.log(`Number that reached minimum times: ${sortedRolls[0][0]} (${sortedRolls[0][1]} times)`);
}

simulateDiceRolls();
