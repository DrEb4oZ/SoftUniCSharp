function solve(input, wordToCount) {
    let counter = 0;
    let array = input.split(' ');
    for (const word of array) {
        if(word === wordToCount){
            counter++;
        }
    }

    console.log(counter);
}


solve('This is a word and it also is a sentence','is');
solve('softuni is great place for learning new programming languages','softuni');