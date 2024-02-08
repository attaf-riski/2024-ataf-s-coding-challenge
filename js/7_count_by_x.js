// https://www.codewars.com/kata/5513795bd3fafb56c200049e/train/javascript

function countBy(x, n) {
    let z = [];
    let y = x;

    for(var i=0;i<n;i++){
        z.push(y)
        y += x;
    }

  
    return z;
  }

console.log(countBy(1,10))
console.log(countBy(2,5))