function solve(input) {
    let tempArray = input.slice().sort((a, b) => a - b);
    let result = [];
    for (let i = 0; i < input.length; i++) {
        if(i % 2 === 0){
            result.push(tempArray.shift());
        }
        else{
            result.push(tempArray.pop());
        }
        
    }

    return result;
}

solve([1, 65, 3, 52, 48, 63, 31, -3, 18, 56]);