function solve(input) {
    let person = JSON.parse(input);

    for (const key in person){
        console.log(`${key}: ${person[key]}`);
    }
}



solve('{"name": "George", "age": 40, "town": "Sofia"}');