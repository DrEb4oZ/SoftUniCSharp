function solve(firstNumber, secondNumber) {
    function factorialCalc(number) {
        let result = 1;
        for(let i = number; i > 1; i--){
            result *= i;
        }

        return result;
    }

    let result = factorialCalc(firstNumber) / factorialCalc(secondNumber);

    console.log(result.toFixed(2));
}


solve(5, 2);
solve(6, 2);