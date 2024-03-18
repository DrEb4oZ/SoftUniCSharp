function solve(textToReplace, inputString) {
    let textToReplaceArray = textToReplace.split(', ');
    for (let i = 0; i < textToReplaceArray.length; i++) {
        inputString = inputString.replace('*'.repeat(textToReplaceArray[i].length), textToReplaceArray[i])
    }
    console.log(inputString);
}



solve('great','softuni is ***** place for learning new programming languages');
solve('great, learning','softuni is ***** place for ******** new programming languages');