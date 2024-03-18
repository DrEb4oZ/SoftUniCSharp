function solve(firstNumber, secondNumber, thirdNumber) {
    function sum(first, second) {
        return first + second;
    }

    function subtract(first,second) {
        return first - second;
    }


    let result = subtract(sum(firstNumber, secondNumber), thirdNumber);
    console.log(result);
}


solve(23, 6, 10);
solve(1, 17, 30);
solve(42, 58, 100);