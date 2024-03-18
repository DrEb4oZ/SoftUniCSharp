function solve(x1, y1, x2, y2){
    let firstComparison = Math.sqrt(Math.pow((0 - x1),2) + Math.pow((0 - y1),2));
    let secondComparison = Math.sqrt(Math.pow((x2 - 0),2) + Math.pow((y2 - 0),2));
    let thirdComparison = Math.sqrt(Math.pow((x2 - x1),2) + Math.pow((y2 - y1),2));
    
    if(Number.isInteger(firstComparison)){
        console.log(`{${x1}, ${y1}} to {0, 0} is valid`);
    } else{
        console.log(`{${x1}, ${y1}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(secondComparison)){
        console.log(`{${x2}, ${y2}} to {0, 0} is valid`);
    } else{
        console.log(`{${x2}, ${y2}} to {0, 0} is invalid`);
    }

    if(Number.isInteger(thirdComparison)){
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
    } else{
        console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
    }

}





solve(3, 0, 0, 4);
solve(2, 1, 1, 1);
