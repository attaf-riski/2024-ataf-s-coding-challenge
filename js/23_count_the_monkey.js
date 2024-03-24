function monkeyCount(n) {
    let arr = [];
    for (let i = 1; i <= n; i++) {
        arr.push(i);
    }
    return arr;
}

console.log(monkeyCount(5)); // [1, 2, 3, 4, 5]