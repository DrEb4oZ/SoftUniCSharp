function solve(input) {
    let counter = 1;
    input.sort((a, b) => a.localeCompare(b))
    .forEach(n => {
        console.log(`${counter}.${n}`);
        counter++;
    })
   
}


solve(["John", "Bob", "Christina", "Ema"]);