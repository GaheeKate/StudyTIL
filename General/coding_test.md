# Coding test 
 
Today I practiced coding test and leet code_easy

- I tried online coding test for the first time
It was 3 problems in 50 mins
I don't think it is possible to solve all in time without knowing all types of questions and practicing.. lets practice more!!

### Coding test problem not solved in time
#### Total bias amount

- A programming organization is planning a contest for several programmers, each of which has a certain rating. (The higher the rating, the better the programmer.) Each programmer is paired with another programmer, and the difference between their ratings is referred to as the "bias amount". Given the ratings of all the programmers in the contest, what is the minimum total bias amount that can be achieved by optimally planning the programmer pairs?

  > Example
n = 4
ratings = [4, 2, 5, 1]
The optimal solution is:
Pair the second programmer (2) with the fourth (1) for a difference of 1.
Pair the first programmer (4) with the third (5) for a difference of 1.
This results in a total bias amount of 1 + 1 = 2.



##### Thoughts
- I don't know if it is right. check if they would post a solution later. 
- How I did
``` js
function compareNumbers(a, b) {
    return a - b;
}

function bias(ratings) {
    var re = ratings.sort(compareNumbers)
    var an = 0
    console.log(re)
    for (i = 0; i < re.length; i++) {
        an = an + ((re[i + 1]) - re[i])
        re.splice(0, 2)
        i--;
    }
    return an;
};

console.log(bias([4, 2, 5, 1])) -> 2
console.log(bias([1, 3, 7, 5, 10, 12])) -> 6

```

### JS
#### 1. Two Sum

##### Thoughts
- I wanted to solve with one for loop by sorting the array like below,
 and I realized it requires to return index of the array. I could have used this one if it required to return values

-How I tried at first
``` js
function compareNumbers(a, b) {
    return a - b;
}

var twoSum = function (nums, target) {
    nums = nums.sort(compareNumbers);
    for (i = 0; i < nums.length - 1; i++) {
        if (nums[i] + nums[nums.length - 1] > target) {
            nums.length--;
            i--;
        }
        else {
            return ([nums[i], nums[nums.length - 1]])
        }

    }
}
 ```


- How I did instead

``` js

var twoSum = function (nums, target) {

    for (i = 0; i < nums.length - 1; i++) {
        for (j = i + 1; j < nums.length; j++) {
            if (nums[i] + nums[j] === target) {
                return [i, j]
            }
        }
    }
}```
