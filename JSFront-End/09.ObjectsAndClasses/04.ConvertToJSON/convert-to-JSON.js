function solve(firstName, lastName, color) {
    let person = {name: firstName, lastName, hairColor: color};
    let personJSON = JSON.stringify(person);
    console.log(personJSON);
}


solve('George', 'Jones', 'Brown');