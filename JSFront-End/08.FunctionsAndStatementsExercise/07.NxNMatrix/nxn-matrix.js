function solve(number) {
    function draw(number) {
        for (let i = 0; i < number; i++) {
            console.log(`${(String(number) ).repeat(number)}`);
        }
    }
    draw(number);
}


solve(3);
solve(7);
solve(2);