function solve(input) {
    let addressBook = {};
    for (const record of input) {
        const [person, address] = record.split(':');
        addressBook[person] = address;
    }

    const tempArray = Object.entries(addressBook);
    tempSortedArray = tempArray.sort((a, b) => a[0].localeCompare(b[0]));
    addressBook = Object.fromEntries(tempArray);

    for (const record in addressBook) {
        console.log(`${record} -> ${addressBook[record]}`);
    }
}



solve(['Tim:Doe Crossing',
'Bill:Nelson Place',
'Peter:Carlyle Ave',
'Bill:Ornery Rd']
);