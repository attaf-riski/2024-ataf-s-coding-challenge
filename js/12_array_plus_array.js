// https://www.codewars.com/kata/5a2be17aee1aaefe2a000151/train/javascript

function arrayPlusArray(arr1, arr2) {
    return arr1.reduce((total, current) => {
        return total + current;
    }, arr2.reduce((total, current) => {
        return total + current;
    }, 0)); //something went wrong
  }

console.log(arrayPlusArray([-1, -2, -3], [-4, -5, -6]));