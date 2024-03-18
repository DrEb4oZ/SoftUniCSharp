function solve(fruitType, fruitWeight, fruitPricePerKg) {
    let totalPrice = fruitPricePerKg * fruitWeight / 1000;
    console.log(`I need $${totalPrice.toFixed(2)} to buy ${(fruitWeight / 1000).toFixed(2)} kilograms ${fruitType}.`);
}

solve('orange', 2500, 1.80);