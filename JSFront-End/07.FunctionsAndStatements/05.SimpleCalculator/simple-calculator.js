function solve(firstNumber, secondNumber, operator) {
    function simpleCalculator(firstNumber, secondNumber, operator) {
        switch (operator) {
            case 'multiply':
            return firstNumber * secondNumber;
            case 'divide':
            return firstNumber / secondNumber;
            case 'add':
            return firstNumber + secondNumber;
            case 'subtract':
            return firstNumber - secondNumber;
        }
    }
    let result = simpleCalculator(firstNumber, secondNumber, operator);
    console.log(result);
}


solve(5, 5, 'multiply');
solve(40, 8, 'divide');
solve(12, 19, 'add');
solve(50, 13, 'subtract');
