function solve(input, rotationCount) {
    for (let i = 0; i < rotationCount; i++) {
        let tempElement = input.shift();
        input.push(tempElement);
    }

    console.log(input.join(' '));
}


solve([51, 47, 32, 61, 21], 2);
solve([32, 21, 61, 1], 4);
solve([2, 4, 15, 31], 5);