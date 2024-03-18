function solve(lostCount, helmetPrice, swordPrice, shiledPrice, armorPrice){
    let totalCost = 0;
    let helmCounter = 0;
    let swordCounter = 0;
    let shieldCounter = 0;
    let helmBroken = false;
    let swordBroken = false;

    for (let i = 0; i < lostCount; i++) {
        helmCounter++;
        swordCounter++;
        if(helmCounter == 2){
            helmBroken = true;
            helmCounter = 0;
            totalCost += helmetPrice;
        }

        if(swordCounter == 3){
            swordBroken = true;
            swordCounter = 0;
            totalCost += swordPrice;
        }

        if (helmBroken && swordBroken){
            shieldCounter++;
            totalCost += shiledPrice;
        }

        if(shieldCounter == 2){
            shieldCounter = 0;
            totalCost += armorPrice;
        }

        helmBroken = false;
        swordBroken = false;
    }

    console.log(`Gladiator expenses: ${totalCost.toFixed(2)} aureus`);
}



solve(7,
    2,
    3,
    4,
    5
    );

solve(23,
    12.50,
    21.50,
    40,
    200
    );