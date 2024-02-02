// first shot
// Time complexity : O(n)
const reverseSeq = n => {
    var result = new Array(n);
    for(var i=n;i>0;i--){
        result[n-i] = i;
    }
    return result;
};

console.log(reverseSeq(5))


