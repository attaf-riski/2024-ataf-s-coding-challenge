function feast(beast, dish) {
    if(beast.toLowerCase().charAt(0) === dish.toLowerCase().charAt(0) && beast.toLowerCase().charAt(beast.length - 1) === dish.toLowerCase().charAt(dish.length - 1)){
        return true;
    }
    return false;
}

console.log(feast("great blue heron", "garlic naan"));