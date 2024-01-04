/\*\*

- @param {number[]} flowerbed
- @param {number} n
- @return {boolean}
  \*/

  var canPlaceFlowers = function(flowerbed, n) {
  //plant first
  //b is the count of flowers can be planted
  var b=0;
  //compare each plot with the for loop
  for(var i=0;i<=flowerbed.length;i++)
  {
  //if the plot is empty
  if(flowerbed[i]==0){
  //will see the previous plot and next plot is also empty
  //if the plot is at the first, should give the previous plot of the first plot 0
  //same to the last one
  var prev = ((i==0||flowerbed[i-1]==0)?0:1);
  var next = ((i==flowerbed.length-1||flowerbed[i+1]==0)?0:1);

//if prev plot and next plot is empty
//the plot is available
if(prev ==0 && next==0)
{
//then count up the b and make the spot planted
b++
flowerbed[i]=1; }

          }
      }
      //if the available spots are more than n, return true
      if(b>=n){return true}
      else{return false}

};
