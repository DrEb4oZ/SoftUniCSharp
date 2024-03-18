function solve(firstNumber, secondNumber, thirdNumber) {
    function getSmallestOfTwo(first, second) {
            if(first <= second){
                return first;
            } else {
                return second;
            }
    }

    result = getSmallestOfTwo(getSmallestOfTwo(firstNumber, secondNumber), thirdNumber);
    console.log(result);
}



solve(2, 5, 3);
solve(600, 342, 123);
solve(25, 21, 4);
solve(2, 2, 2);