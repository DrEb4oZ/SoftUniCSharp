function solve(number){
    let  sum = 0;
    while (number != 0){
        let digit = number % 10;
        sum += digit;
        number /= 10;
        number = Math.floor(number);
    }

    console.log(sum);
}

solve(97561);