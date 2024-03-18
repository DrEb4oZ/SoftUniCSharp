function solve(array, number) {
    
    let newArray = [];
    for (let i = 0; i < array.length; i+= number) {
        newArray.push(array[i]);
    }
    return newArray;
}


solve(['5', '20', '31', '4', '20'], 2);
solve(['dsa','asd', 'test', 'tset'],2);
solve(['1', '2','3', '4', '5'], 6);
