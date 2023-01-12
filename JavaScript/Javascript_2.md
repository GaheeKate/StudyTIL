# Javascript : 2

Today I studied Javascript


- function showName(name){//No number limit
    console.log(name);
  }

  showName('Mike');// Mike
  showName('Mike','Tom');// Mike

- Rest parameters
  > function showName(...name){
    console.log(name);
  }
  showName('Mike');// ['Mike']
  showName('Mike','Tom');// ['Mike','Tom']

- Spread syntax
  - let result = [...arr1, ...arr2]
  - copy
    > let arr= [1,2,3];
      let arr2 = [...arr]; //[1,2,3]

- Closure
  - A closure is the combination of a function bundled together (enclosed) with references to its surrounding state (the lexical environment). In other words, a closure gives you access to an outer function's scope from an inner function
  - Lexical scoping is the environment that holds the variables of the current scope as well as the outer scope.
  > function makeCounter(){
    let num = 0; // concealment
    return function(){
      return num++
    }
  }
  let counter = makeCounter();

  console.log(counter());


- Call

  >const Mike = {
    name:"Mike"
  }
  function showThisName(){
    console.log(this.name) // this = window
  }
  showThisName()
  showThisName.call(mike) // Mike
- Apply: put array

- Promise
  - The Promise object represents the eventual completion (or failure) of an asynchronous operation and its resulting value. 
  - When you order something, you leave your number to the store. The number is a promise.
    > const pr = new Promise((resolve, reject)=>{
      //code
    });
  - new Promise
    - resolve(value)
      - state: pending    ->   state:fulfilled
      - result: undefined -> result: value </br></br>
    - reject(error)                       
      - state: pending    ->  state:rejected
      - result: undefined  ->  result: error 
  ```js
  const pr = new Promise((resolve, reject)=>{
    setTimeout(()=>{
      resolve('OK')
      },3000)
    });

  const pr = new Promise((resolve, reject)=>{
    setTimeout(()=>{
      reject(new Error('Error'))
      },3000)
    });

  pr.then(
    function(result){
      console.log(result+"Order is ready")
    }).catch(
    function(err){
      console.log("re-order plz")
    }
  ).finally(){
    function(){
      console.log("finished")
    }
  }
  ```