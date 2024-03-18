function solve(input) {
    const phoneBook = {};
    // for (let i = 0; i < input.length; i++) {
    //     let temp = input[i].split(' ');
    //     phoneBook[temp[0]] = temp[1];
    // }

    for (let record of input) {
        const [name, phone] = record.split(' ');
        phoneBook[name] = phone;
    }

    for (const key in phoneBook) {
        console.log(`${key} -> ${phoneBook[key]}`);
    }
}



solve(['Tim 0834212554',
'Peter 0877547887',
'Bill 0896543112',
'Tim 0876566344']
);