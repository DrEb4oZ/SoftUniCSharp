function solve(input) {
    let employees = {};
    for (let i = 0; i < input.length; i++) {

        employees[input[i]] = input[i].length;
        
    }

    for (const employee in employees) {
        console.log(`Name: ${employee} -- Personal Number: ${employees[employee]}`);
    }
}


solve([
    'Silas Butler',
    'Adnaan Buckley',
    'Juan Peterson',
    'Brendan Villarreal'
    ]
    )