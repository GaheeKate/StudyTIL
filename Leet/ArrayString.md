/\*\*

- @param {number[]} candies
- @param {number} extraCandies
- @return {boolean[]}
  \*/

// decalring max value outside of the for loop
var kidsWithCandies = function(candies, extraCandies) {
var maxCandies = Math.max(...candies);
for (var i = 0; i < candies.length; i++) {
candies[i] = candies[i] + extraCandies >= maxCandies;
}

    return candies;

};
