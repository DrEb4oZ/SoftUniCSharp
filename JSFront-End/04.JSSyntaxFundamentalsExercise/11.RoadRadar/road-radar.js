function solve(currentSpeed, areaType) {
    let difference;
    let speedLimit;
    if (areaType === 'motorway'){
        speedLimit = 130;
        if (currentSpeed > 130){
            difference = currentSpeed - speedLimit;
        }
    } else if (areaType === 'interstate'){
        speedLimit = 90;
        if (currentSpeed > 90){
            difference = currentSpeed - speedLimit;
        }
    } else if (areaType === 'city'){
        speedLimit = 50;
        if (currentSpeed > 50){
            difference = currentSpeed - speedLimit;
        }
    } else if (areaType === 'residential'){
        speedLimit = 20;
        if (currentSpeed > 20){
            difference = currentSpeed - speedLimit;
        }
    }

    if (difference != undefined){
        let status = '';
        if (difference <= 20){
            status = 'speeding';
            
        } else if (difference <= 40){
            status = 'excessive speeding';
        } else {
            status = 'reckless driving';
        }

        console.log(`The speed is ${difference} km/h faster than the allowed speed of ${speedLimit} - ${status}`);
    } else{
        console.log(`Driving ${currentSpeed} km/h in a ${speedLimit} zone`);
    }
}


solve(120, 'interstate');