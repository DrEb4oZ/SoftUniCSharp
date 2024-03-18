function solve(input) {
    for (let i = 0; i < input.length; i++) {
        const tokens = input[i].split(' | ');
        const curentTown = tokens[0];
        const latitude = tokens[1];
        const longitude = tokens[2];

        let town = {
            town: curentTown,
            latitude: Number(latitude).toFixed(2),
            longitude: Number(longitude).toFixed(2),
        }
        console.log(town);
    }

}


solve(['Sofia | 42.696552 | 23.32601',
'Beijing | 39.913818 | 116.363625']
);