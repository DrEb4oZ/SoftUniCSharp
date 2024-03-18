function solve(firstNumber, operator, secondNumber) {
    let result;
    switch (operator) {
        case '+':
            result = firstNumber + secondNumber;
        break;
        case '-':
            result = firstNumber - secondNumber;
        break;
        case '*':
            result = firstNumber * secondNumber;
        break;
        case '/':
            result = firstNumber / secondNumber;
        break;
    }

    console.log(result.toFixed(2));
}



solve(5,
    '+',
    10
    );
solve(25.5,
    '-',
    3
    )