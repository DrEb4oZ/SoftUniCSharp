function solve(yield) {
    let dayCount = 0;
    let spices = 0;
    while(yield >= 100){
        dayCount++;
        spices += yield;
        yield -= 10;
        spices -= 26;
    }
    spices -= 26;
    if(spices < 0){
        spices = 0;
    }

    console.log(dayCount);
    console.log(spices);
}


solve(111);
solve(450);