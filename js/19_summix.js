function sumMix(x){
    var buffer = 0;
    x.forEach(element => {
       if(typeof(element) === 'number'){
        buffer += element;
       }else{
        buffer += Number(element);
       } 
    });
    return buffer;
}

console.log(sumMix([9, 3, '7', '3']));