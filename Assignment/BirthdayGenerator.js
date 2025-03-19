function getRandomMonth() {
    return Math.floor(Math.random() * 12) + 1; 
}

function generateBirthMonths() {
    let birthMonths = new Map();

    
    for (let i = 1; i <= 12; i++) {
        birthMonths.set(i, []);
    }

    for (let i = 1; i <= 50; i++) {
        let month = getRandomMonth();
        birthMonths.get(month).push(`Person${i}`);
    }

    return birthMonths;
}

function printBirthdays(birthMonths) {
    console.log("Individuals grouped by birth month:");
    for (let [month, individuals] of birthMonths.entries()) {
        if (individuals.length > 0) {
            console.log(`Month ${month}: ${individuals.join(", ")}`);
        }
    }
}

let birthMonthData = generateBirthMonths();
printBirthdays(birthMonthData);
