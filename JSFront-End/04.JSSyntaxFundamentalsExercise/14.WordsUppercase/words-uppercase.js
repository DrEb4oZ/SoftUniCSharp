function solve(string){
    let newString = '';

    for (let i = 0; i < string.length; i++) {
        
        let newChar = '';

        if(string[i].charCodeAt(0) >= 97 && string[i].charCodeAt(0) <= 122 ){
            newChar = string[i].charCodeAt(0) - 32;
            newString += String.fromCharCode(newChar);
        }else if ((string[i].charCodeAt(0) >= 65 && string[i].charCodeAt(0) <= 90) || (string[i].charCodeAt(0) >= 48 && string[i].charCodeAt(0) <= 57) ){
            newString += string[i];
        }else if (i === 0){
            continue;
        }
        else if(i === string.length - 1 && (string[i].charCodeAt(0) < 97 || string[i].charCodeAt(0) > 122)){
            continue;
        } else if (newString.length > 0 && (string[i].charCodeAt(0) < 97 || string[i].charCodeAt(0) > 122) && newString[newString.length - 1].charCodeAt(0) >= 65 && newString[newString.length - 1].charCodeAt(0) <= 90){
            newString += ',' + ' ';
        }
        
        
        
        // else if(i === string.length-1 || string[i] === ',' || newString[newString.length-1] === ' '){
        //     continue;
        // }else{
        // newString += ',' + ' ';
        // }
        
    }
    
    let finalString = '';
    if (newString.length > 0 && (newString[newString.length - 1].charCodeAt(0) < 65 || newString[newString.length - 1].charCodeAt(0) > 90) && (newString[newString.length - 1].charCodeAt(0) < 48 || newString[newString.length - 1].charCodeAt(0) > 57)){
        for (let i = 0; i < newString.length - 2; i++) {
            finalString += newString[i];
            
        }
        console.log(finalString);
    } else{
        console.log(newString);
    }

}


// solve('hello')
solve('fsd4fsdf4')