/**
 * @param {number} x
 * @return {boolean}
 */

var isPalindrome = function(x) {
    let reverse = x.toString().split('').reverse().join('')
    let str = x.toString()
   return reverse === str
};
