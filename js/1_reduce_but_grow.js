function grow(x){
    return x.reduce(perkalian);
}

function perkalian(total, num){
    return total * num;
}

console.log(grow([2, 2, 2, 2, 2, 2]));