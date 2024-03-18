function solve(number) {

    function getOdd(number) {

        let oddNumbers = '';
        while(number > 0){
            let temp = Math.floor(number % 10);
            number /= 10;
            if(temp % 2 !== 0){
                oddNumbers += temp;
            }
        }

        return oddNumbers;
    }

    function getEven(number) {

        let evenNumbers = '';
        while(number > 0){
            let temp = Math.floor(number % 10);
            number /= 10;
            if(temp % 2 === 0){
                evenNumbers += temp;
            }
        }

        return evenNumbers;
    }



    function sum(number) {
        let sum = 0;
        for (let i = 0; i < number.length; i++) {
            sum += Number(number[i]);
        }

        return sum;
    }

    let oddSum = sum(getOdd(number));
    let evenSum = sum(getEven(number));
    console.log(`Odd sum = ${oddSum}, Even sum = ${evenSum}`);
}


solve(1000435);
solve(3495892137259234);