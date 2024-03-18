function solve(peopleCount, peopleType, dayOfWeek) {
    let price;
    if (dayOfWeek === 'Friday'){
        if (peopleType === 'Students'){
            price = 8.45;
        } else if (peopleType === 'Business'){
            price = 10.90;
        } else if (peopleType === 'Regular'){
            price = 15;
        }
    } else if (dayOfWeek === 'Saturday') {
        if (peopleType === 'Students'){
            price = 9.80;
        } else if (peopleType === 'Business'){
            price = 15.60;
        } else if (peopleType === 'Regular'){
            price = 20;
        }
    } else if (dayOfWeek === 'Sunday'){
        if (peopleType === 'Students'){
            price = 10.46;
        } else if (peopleType === 'Business'){
            price = 16.00;
        } else if (peopleType === 'Regular'){
            price = 22.50;
        }
    }

    let totalPrice;

    if (peopleType === 'Students' && peopleCount >= 30){
        totalPrice = price * peopleCount * 0.85;
    } else if (peopleType === 'Business' && peopleCount >= 100){
        totalPrice = price * (peopleCount - 10);
    } else if (peopleType === 'Regular' && peopleCount >= 10 && peopleCount <= 20){
        totalPrice = price * peopleCount * 0.95;
    } else {
        totalPrice = price * peopleCount;
    }

    console.log(`Total price: ${totalPrice.toFixed(2)}`);
}


solve(40,"Regular","Saturday")