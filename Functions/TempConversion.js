function celsiusToFahrenheit(value) {
    if (typeof value !== 'number') {
        return 'Invalid input: Temperature must be a number';
    }
    if (value < 0 || value > 100) {
        return 'Input out of range. Must be between 0°C and 100°C';
    }
    return `${value}°C is ${(value * 9/5 + 32).toFixed(2)}°F`;
}

function fahrenheitToCelsius(value) {
    if (typeof value !== 'number') {
        return 'Invalid input: Temperature must be a number';
    }
    if (value < 32 || value > 212) {
        return 'Input out of range. Must be between 32°F and 212°F';
    }
    return `${value}°F is ${((value - 32) * 5/9).toFixed(2)}°C`;
}

console.log(celsiusToFahrenheit(25)); 
console.log(fahrenheitToCelsius(77));
console.log(celsiusToFahrenheit(150)); 
