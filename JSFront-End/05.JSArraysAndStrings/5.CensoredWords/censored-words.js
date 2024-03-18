function solve(input, censoredWord) {

    while(input.includes(censoredWord)){

        input = input.replace(censoredWord, '*'.repeat(censoredWord.length));
    }

    console.log(input);
}



solve('A small sentence with some words', 'small');
solve('Find the hidden word', 'hidden');