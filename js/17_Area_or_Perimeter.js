// https://www.codewars.com/kata/5ab6538b379d20ad880000ab/solutions/javascript

const areaOrPerimeter = function(l , w) {
    return (l==w)?l*w:2*(l+w);
  };

  console.log(areaOrPerimeter(4,4))
  console.log(areaOrPerimeter(2,4))
