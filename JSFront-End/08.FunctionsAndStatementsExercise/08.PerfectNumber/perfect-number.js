function solve(number) {
    function aliquotSum(number) {
        let sum = 0;
        for (let i = 1; i < number; i++) {
            if(number % i === 0){
                sum += i;
            }
        }
        return sum;
    }

    if(aliquotSum(number) === number){
        console.log('We have a perfect number!');
    } else{
        console.log('It\'s not so perfect.');
    }
}

solve(1236498);