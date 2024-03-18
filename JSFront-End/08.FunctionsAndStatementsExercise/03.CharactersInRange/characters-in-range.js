function solve(firstChar, secondChar) {
    function getCharsBetween(firstChar, secondChar) {
        let result = '';

        for (let i = getSmalletASCIIChar(firstChar, secondChar) + 1; i < getBigestASCIIChar(firstChar, secondChar); i++) {
            result += String.fromCharCode(i) + ' ';
            
        }

        return result;
    }

    function getSmalletASCIIChar(firstChar, secondChar) {
        if (firstChar < secondChar){
            return firstChar.charCodeAt(0);
        } else{
            return secondChar.charCodeAt(0);
        }
    }

    function getBigestASCIIChar(firstChar, secondChar) {
        if (firstChar > secondChar){
            return firstChar.charCodeAt(0);
        } else{
            return secondChar.charCodeAt(0);
        }
    }

    console.log(getCharsBetween(firstChar, secondChar));
}


solve('a', 'd');
solve('#', ':');
solve('C', '#');