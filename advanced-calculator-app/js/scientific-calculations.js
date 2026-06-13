function calculateSine(angle) {
    return Math.sin(angle * (Math.PI / 180)); // Convert angle to radians
}

function calculateCosine(angle) {
    return Math.cos(angle * (Math.PI / 180)); // Convert angle to radians
}

function calculateTangent(angle) {
    return Math.tan(angle * (Math.PI / 180)); // Convert angle to radians
}

function calculateLogarithm(value, base) {
    return Math.log(value) / Math.log(base); // Change of base formula
}

function calculateExponential(base, exponent) {
    return Math.pow(base, exponent);
}

function calculateSquareRoot(value) {
    return Math.sqrt(value);
}

function calculateFactorial(n) {
    if (n < 0) return undefined; // Factorial is not defined for negative numbers
    if (n === 0 || n === 1) return 1;
    let result = 1;
    for (let i = 2; i <= n; i++) {
        result *= i;
    }
    return result;
}

function calculatePower(base, exponent) {
    return Math.pow(base, exponent);
}

function calculateRadians(degrees) {
    return degrees * (Math.PI / 180);
}

function calculateDegrees(radians) {
    return radians * (180 / Math.PI);
}