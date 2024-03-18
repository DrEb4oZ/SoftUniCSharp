function solve(firstNumber, secondNumber, operation) {
    switch (operation) {
        case '+':
           console.log(firstNumber + secondNumber); 
        break;
        case '-':
            console.log(firstNumber - secondNumber); 
        break;
        case '*':
            console.log(firstNumber * secondNumber); 
        break;
        case '/':
            console.log(firstNumber / secondNumber); 
        break;
        case '%':
            console.log(firstNumber % secondNumber); 
        break;
        case '**':
            console.log(firstNumber ** secondNumber); 
        break;
    }
}

solve(10, 2, '**')