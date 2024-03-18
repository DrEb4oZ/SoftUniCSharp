function solve(number) {
    let sum = 0;
    let lastDigit;
    let areEqual = true;
    while (number != 0) {
        let digit = number % 10;
        sum += digit;
        if (lastDigit != undefined && areEqual){
            if (lastDigit != digit){
                areEqual = false;
            }
        }
        lastDigit = digit;
        number = Math.floor(number / 10);
    }
    console.log(areEqual);
    console.log(sum);
}


solve(1234);