function solve(input) {
    let regexTemp = /[A-Z]/gm;
    // console.log(input.split(regexTemp).join(', '));
    let tempString = '';
    let result = [];
    for (let i = 0; i < input.length; i++) {
        if(i !== 0 && input[i] === input[i].toUpperCase()){
            result.push(tempString);
            tempString = '';
        }
        tempString += input[i];
        
    }
    result.push(tempString);

    console.log(result.join(', '));

}



solve('SplitMeIfYouCanHaHaYouCantOrYouCan');
solve('HoldTheDoor');
solve('ThisIsSoAnnoyingToDo');
