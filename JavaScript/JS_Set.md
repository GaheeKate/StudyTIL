### SET

#### Unlike arrays, sets do not allow duplicate elements, ensuring that each element in the set is unique.

```js
// Adding elements
mySet.add(1);
mySet.add({ key: "value" });

// Deleting an element
mySet.delete("hello");

// Iterating over the set
for (let item of mySet) {
  console.log(item);
}

// Clearing the set
mySet.clear();

//remove duplicate values from an array
const numbers = [1, 2, 2, 3, 4, 4, 5];
const uniqueNumbers = [...new Set(numbers)];
console.log(uniqueNumbers); // [1, 2, 3, 4, 5]
```
