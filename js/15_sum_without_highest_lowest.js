// https://www.codewars.com/kata/576b93db1129fcf2200001e6/train/javascript

function sumArray(array) {
    if(array === undefined){
        return 0;
    }
    if (array === null || array.length < 3) {
        return 0;
    }
    array.sort((a, b) => a - b);
    return array.reduce((acc, cur, i) => (i === 0 || i === array.length - 1) ? acc : acc + cur, 0);
}

console.log(sumArray(undefined));

