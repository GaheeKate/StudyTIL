/\*\*

- @param {string} word1
- @param {string} word2
- @return {string}
  \*/

``` js
  var mergeAlternately = function(word1, word2) {
  //starting with word1

var resarr = [];

var longerone =word1.length > word2.length ? word1.length : word2.length
for(var i=0; i<longerone; i++){

    if (i < word1.length) {
      resarr.push(word1[i]);
    }
    if (i < word2.length) {
      resarr.push(word2[i]);
    }

}

return resarr.join('');
};

```

- @param {string} word1
- @param {string} word2
- @return {string}
``` js
  var mergeAlternately = function(word1, word2) {
  var res = '';
  var longerOne = Math.max(word1.length, word2.length);

for (var i = 0; i < longerOne; i++) {
if (i < word1.length) {
res += word1[i];
}
if (i < word2.length) {
res += word2[i];
}
}

return res;
};
```
