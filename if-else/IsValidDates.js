const day = parseInt(process.argv[2], 10);
const month = parseInt(process.argv[3], 10);


if (isNaN(day) || isNaN(month) || month < 1 || month > 12 || day < 1 || day > 31) {
    console.log("Please enter a valid day (1-31) and month (1-12).");
} else {

    const isInRange =
        (month === 3 && day >= 20) ||
        (month === 4) ||
        (month === 5) ||
        (month === 6 && day <= 20);

    console.log(isInRange);
}