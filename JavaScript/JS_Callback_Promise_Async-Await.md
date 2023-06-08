
## Synchronous code
- follows a sequential execution model. Each line of code is executed one after another, and the program waits for each line to finish before moving on to the next one. In sync code, if there is a time-consuming task, such as fetching data from a server or performing a complex calculation, the program will halt until that task is completed.


## Asynchronous code. 
- It allows tasks to be executed concurrently and asynchronously. When an async task is initiated, the program doesn't wait for it to complete but instead continues executing the remaining code. Once the async task finishes, a callback, promise, or async/await syntax is used to handle the result.


## Callbacks, Promises, Async/await : Techniques used for managing asynchronous operations and handling their results. 


### Callbacks: 
- Callbacks have been traditionally used as a way to handle asynchronous processes in JavaScript.
- Callbacks are functions that are passed as arguments to other functions and are invoked once the asynchronous operation is complete. Callbacks are also commonly used with functions that perform asynchronous operations like fetching data from an API.

``` js
operation1((error, result1) => {
  if (error) {
 ...
    return;
  }

  operation2(result1, (result2) => {
   
    operation3(result2, (result3) => {
	...
    });
  });
});

```

### Promises
- Promise represents a value that may be available now, in the future, or never. It has three possible states: pending, fulfilled, or rejected. You can attach callbacks to these states using the .then() and .catch() methods
- The .then() method is used to handle the fulfillment state of a promise, while the .catch() function is used to handle the rejection state.



### Async-Await
- async/await syntax is a more recent addition to JavaScript and provides a cleaner and more concise way to write asynchronous code compared to callbacks and promises. It is built on top of promises and offers a more synchronous-like style of coding. A function that is declared as async, will always return a promise.
await keyword is used to pause the execution until the promise is fulfilled or rejected.

``` js
async function example() {
  console.log('Before awaiting');

  const result = await somePromise(); // Execution suspends here until the promise settles

  console.log('After awaiting');
  console.log('Result:', result);
}

console.log('Start');
example();
console.log('End');
```

```
Start
Before awaiting
End
After awaiting
Result: <resolved value or rejected error>
```
