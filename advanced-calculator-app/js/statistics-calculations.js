function calculateMean(data) {
    const total = data.reduce((acc, num) => acc + num, 0);
    return total / data.length;
}

function calculateMedian(data) {
    const sorted = data.slice().sort((a, b) => a - b);
    const mid = Math.floor(sorted.length / 2);
    if (sorted.length % 2 === 0) {
        return (sorted[mid - 1] + sorted[mid]) / 2;
    } else {
        return sorted[mid];
    }
}

function calculateMode(data) {
    const frequency = {};
    let maxFreq = 0;
    let modes = [];

    data.forEach(num => {
        frequency[num] = (frequency[num] || 0) + 1;
        if (frequency[num] > maxFreq) {
            maxFreq = frequency[num];
        }
    });

    for (const num in frequency) {
        if (frequency[num] === maxFreq) {
            modes.push(Number(num));
        }
    }

    return modes.length === data.length ? [] : modes;
}

function calculateStandardDeviation(data) {
    const mean = calculateMean(data);
    const squaredDiffs = data.map(num => Math.pow(num - mean, 2));
    const variance = calculateMean(squaredDiffs);
    return Math.sqrt(variance);
}