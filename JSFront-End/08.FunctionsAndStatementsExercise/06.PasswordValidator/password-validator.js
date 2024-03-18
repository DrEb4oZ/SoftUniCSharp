function solve(text) {
    function isLength6To10(text) {
        return text.length >= 6 && text.length <= 10;
    }    

    function isOnlyLettersAndDigits(text) {
        let regexTemplate = /[A-Za-z0-9]+/g;
        let matches = text.match(regexTemplate);
        if(matches !== null){
            return text.length === matches[0].length;
        }
        return false;

    }

    function useAtLeastTwoDigits(text) {
        let countDigits = 0;
        let temp = String(text);
        for (let i = 0; i < temp.length; i++) {
            if(temp[i] >= '0' && temp[i] <= '9'){
                countDigits++;
            }

            if(countDigits >= 2){
                return true;
            }
        }

        return false;
    }

    if (!isLength6To10(text)){
        console.log('Password must be between 6 and 10 characters');
    }
    if (!isOnlyLettersAndDigits(text)){
        console.log('Password must consist only of letters and digits');
    }
    if (!useAtLeastTwoDigits(text)){
        console.log('Password must have at least 2 digits');
    }

    if (isLength6To10(text) && isOnlyLettersAndDigits(text) && useAtLeastTwoDigits(text)){
        console.log('Password is valid');
    }


}


// solve('logIn');
// solve('MyPass123');
// solve('Pa$s$s');

solve('$$')