function solve(numberArray) {

    function mirrorNumber(number) {
        let result ='';
        let temp = String(number);
        for(let i =temp.length - 1; i >= 0; i--){
            result += temp[i];
        }
        
        return result;
    }

    for (let i = 0; i < numberArray.length; i++) {
        console.log(numberArray[i] == mirrorNumber(numberArray[i]));        
    }
}


solve([123, 323, 421, 121]);
solve([32, 2, 232, 1010]);