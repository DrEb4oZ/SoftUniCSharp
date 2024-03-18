function solve(text, repeatCount) {
    console.log(repeatString(text, repeatCount));

    function repeatString(text, repeatCount) {
        let result = '';
        for (let i = 0; i < repeatCount; i++) {
            result += text;
        }

        return result;
    }
}


solve('abc', 3);
solve('String', 2);