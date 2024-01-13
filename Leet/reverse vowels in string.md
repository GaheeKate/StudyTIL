```js
/**
 * @param {string} s
 * @return {string}
 */
var reverseVowels = function(s) {
    const vowels = new Set(['a', 'i', 'o', 'u', 'e']);
    const sArray = s.split('');

    let left = 0;
    let right = sArray.length - 1;

    while (left < right) {
        // Find the next vowel from the left
        while (left < right && !vowels.has(sArray[left].toLowerCase())) {
            left++;
        }

        // Find the next vowel from the right
        while (left < right && !vowels.has(sArray[right].toLowerCase())) {
            right--;
        }

        // Swap vowels
        if (left < right) {
            [sArray[left], sArray[right]] = [sArray[right], sArray[left]];
            left++;
            right--;
        }
    }

    return sArray.join('');
};


----------
/**
 * @param {string} s
 * @return {string}
 */

const reverseVowels = function(s) {
    // Match all vowels (case-insensitive) and store them in the array 'vow'
    const vow = s.match(/[aeiou]/ig);

    // Replace each vowel in the original string with the popped vowel from 'vow'. replace () function is case-sensitive
    return s.replace(/[aeiou]/ig, el => vow.pop());
};

```

- The Two Pointers technique involves maintaining two pointers that traverse the given data structure at different speeds or starting positions. These pointers can move toward each other, away from each other, or follow specific rules based on the problem's requirements.
