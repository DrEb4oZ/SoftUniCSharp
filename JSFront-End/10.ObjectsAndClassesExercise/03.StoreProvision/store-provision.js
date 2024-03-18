function solve(currentProducts, deliveredProducts) {
    let products = {};
    for (let i = 1; i < currentProducts.length; i+=2) {
        products[currentProducts[i-1]] = Number(currentProducts[i]);
    }

    for (let i = 1; i < deliveredProducts.length; i+=2) {
        if(products.hasOwnProperty(deliveredProducts[i-1])){
            products[deliveredProducts[i-1]] += Number(deliveredProducts[i]);
        } else{
            products[deliveredProducts[i-1]] = Number(deliveredProducts[i]);
        }
        
    }

    for(let product in products){
        console.log(`${product} -> ${products[product]}`);
    }
}



solve(['Chips', '5', 'CocaCola', '9', 'Bananas', '14', 'Pasta', '4', 'Beer', '2'],['Flour', '44', 'Oil', '12', 'Pasta', '7', 'Tomatoes', '70', 'Bananas', '30'])