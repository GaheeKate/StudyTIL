### JSON.stringify

#### JSON.stringify() converts a JavaScript value to a JSON string.
```js
var a = JSON.stringify(7) 
var b = JSON.stringify('asdf')
var c = JSON.stringify(true)
var d = JSON.stringify(null) 
console.log(typeof a,a)
console.log(typeof b,b)
console.log(typeof c,c)
console.log(typeof d,d)
// string
// 7
// string
// "asdf"
// string
// true
// string
// null
```
#### function
```js
function replacer(key, value) {
if (typeof value === 'number') {
return undefined;
}
return value;
}
var foo = {name: 'Tan', type: 'pomeranian', weight: 4};
var useJson = JSON.stringify(foo, replacer);
console.log(useJson) // {"name":"Tan","type":"pomeranian"}
```
#### array
```js
var foo = {name: 'Tan', type: 'pomeranian', weight: 4};
var useJson = JSON.stringify(foo, ['name', 'type']);
console.log(useJson); // {"name":"Tan","type":"pomeranian"}
```
#### string
```js
var foo = JSON.stringify({a: 2}, null, 'string');
console.log(foo);
// {
// string"a": 2
// }
```
#### number
```js
var space = JSON.stringify({a: 2}, null, 5);
console.log(space);
//5 empty spaces
// {
//      "a": 2
// }
```