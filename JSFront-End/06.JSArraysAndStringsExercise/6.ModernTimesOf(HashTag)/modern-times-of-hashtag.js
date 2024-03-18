function solve(input) {
    let regExpTemp = /#[a-zA-Z]+/gm;
    let matches = input.match(regExpTemp);
    if (matches !== null){
        for (let i = 0; i < matches.length; i++) {
            console.log(matches[i].substring(1));
        }
    }
}



solve('Nowadays everyone uses # to tag a #special word in #socialMedia');
solve('The symbol # is known #variously in English-speaking #regions as the #number sign');