// https://www.codewars.com/kata/5b077ebdaf15be5c7f000077/solutions/javascript

var countSheep = function (num){
    var result = '';
    if(num === 0) return result;  

    for(var i=1;i<=num;i++){
        var buffer = i.toString()+" sheep...";
        result = result.concat(buffer);
    }
    return result;
}

console.log(countSheep(3));