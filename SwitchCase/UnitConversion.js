const choice = parseInt(process.argv[2], 10);
const value = parseFloat(process.argv[3]);

if (isNaN(choice) || isNaN(value) || choice < 1 || choice > 4) {
    console.log("Invalid input! Please enter a valid choice (1-4) and a numeric value.");
} else {
    let result;

    switch (choice) {
        case 1:
            result = value * 12; // Feet to Inch
            console.log(`${value} Feet = ${result} Inches`);
            break;
        case 2:
            result = value * 0.3048; // Feet to Meter
            console.log(`${value} Feet = ${result.toFixed(4)} Meters`);
            break;
        case 3:
            result = value / 12; // Inch to Feet
            console.log(`${value} Inches = ${result.toFixed(4)} Feet`);
            break;
        case 4:
            result = value / 0.3048; // Meter to Feet
            console.log(`${value} Meters = ${result.toFixed(4)} Feet`);
            break;
        default:
            console.log("Invalid choice! Please enter a number between 1 and 4.");
    }
}
