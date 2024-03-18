function solve(number) {
    function drawLoadingBar(number) {
        return `[${'%'.repeat(number / 10)}${'.'.repeat(10- number / 10)}]`
    }


    if (number !== 100){
        console.log(`${number}% ${drawLoadingBar(number)}`);
        console.log('Still loading...');
    } else {
        console.log(`${number}% Complete!`);
        console.log(drawLoadingBar(number));
    }
}


solve(100);