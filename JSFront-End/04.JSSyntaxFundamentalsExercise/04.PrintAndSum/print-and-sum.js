function solve(firstNumber, secondNumber) {
    let numbers = '';
    let sum = 0;
    for (let i = firstNumber; i <= secondNumber; i++) {
        numbers += i + ' ';
        sum += i;
    }
    console.log(numbers);
    console.log(`Sum: ${sum}`);
}


solve(0, 10);