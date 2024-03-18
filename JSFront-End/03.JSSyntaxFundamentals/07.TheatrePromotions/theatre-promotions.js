function solve(dayType, age){
    let price;
    if (dayType === 'Weekday'){
        if (age >= 0 && age <= 18 || age > 64 && age <= 122){
            price = 12;
        } else if (age > 18 && age <= 64){
            price = 18;
        }
    } else if (dayType === 'Weekend'){
        if (age >= 0 && age <= 18 || age > 64 && age <= 122){
            price = 15;
        } else if (age > 18 && age <= 64){
            price = 20;
        }
    } else if (dayType === 'Holiday'){
        if (age >= 0 && age <= 18){
            price = 5;
        } else if (age > 18 && age <= 64){
            price = 12;
        } else if (age >64 && age <=122){
            price = 10;
        }
    }

    if (price !== undefined){
        console.log(`${price}$`);
    }   else{
        console.log('Error!');
    }
}

solve('Holiday', 15);