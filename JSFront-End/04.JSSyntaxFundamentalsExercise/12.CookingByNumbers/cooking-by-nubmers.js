function solve(number, firstOperation, secondOperation, thirdOperation, fourthOperation, fifthOperation) {
    let array = [firstOperation, secondOperation, thirdOperation, fourthOperation, fifthOperation];
    for (let i = 0; i < array.length; i++) {
        const element = array[i];

        switch (array[i]) {
            case 'chop':
                number /= 2;
                break;
            case 'dice':
                number = Math.sqrt(number);
                break;
            case 'spice':
                number += 1;
                break;
            case 'bake':
                number *= 3;
                break;
            case 'fillet':
                number -= number * 0.20;
                break;
        }
        
        console.log(number);
        
    }

}

solve('9', 'dice', 'spice', 'chop', 'bake', 'fillet');