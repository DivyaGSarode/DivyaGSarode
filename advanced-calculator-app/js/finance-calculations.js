function calculateCompoundInterest(principal, rate, time) {
    return principal * Math.pow((1 + rate / 100), time);
}

function calculateLoanPayment(principal, annualRate, years) {
    let monthlyRate = annualRate / 100 / 12;
    let numberOfPayments = years * 12;
    return (principal * monthlyRate) / (1 - Math.pow((1 + monthlyRate), -numberOfPayments));
}

function calculateInvestmentReturn(initialInvestment, annualRate, years) {
    return initialInvestment * Math.pow((1 + annualRate / 100), years);
}

function calculateFutureValue(presentValue, rate, time) {
    return presentValue * Math.exp(rate * time);
}

function calculatePresentValue(futureValue, rate, time) {
    return futureValue / Math.exp(rate * time);
}