# TypeScript
 
Today I studied TypeScript 

- Why use TypeScript?: TypeScript is Statically typed language. Checks types of variables when it compiles.
Can find errors in advance.
- Spends more time on coding than JS. 
- :type
```typescript
    function showItems(arr:number[]){
    arr.forEach((item)=>{
        console.log(item);
    });
  }

  showItems([1,2]);


```

- void: returns nothing
  > function sayHello():void{
    console.log('hello');
}

- never: always returns error or true 
  > function infLoop():never{
    while(true){
    }
  }

- enum: assign numbers to similarly enumerated values. force only certain values to be entered.
to reduces errors caused by transposing or mistyping numbers.
  > enum Os{
    Window,
    Ios,
    Android}
    console.log(Os[1])
    let myOs:Os;
    myOs=Os.Window


- null, undefined


- interface:Interfaces are capable of describing the wide range of shapes that JavaScript objects can take.

```typescript

type Score = 'A'|'B';
interface User{
name:string;
age:number;
gender?:string;
readonly birthYear:number;
[gradekey:number] : Score;
}

let user : User={
    name: 'xx',
    age: 30,
    birthYear: 2000,
    2:'B'
}

user.gender='male'
//user.birthYear=1990; error
console.log(user.name)

interface Add{
    (num1:number,num2:number):number;
}

const add : Add = function(x,y){
    return x+y;
}

add(10,20)


//implements
interface Car{
    color: string;
    wheels:number;
    start():void;
}

class BMW implements Car{
    color='red';
    wheels=4;
    constructor(c:string){
        this.color = c;
    }
    start(){
        console.log('go,,')
    }
}

const b = new BMW('Green');
console.log(b)
b.start();


//extends

interface Kia extends Car{
    door: number;
    stop(): void;
}

class Kia implements Car{
    door=5;
    color='red';
    wheels=5;
    constructor(c:string){
        this.color = c;
    }
    start(){
        console.log('go,,')
    }
}

interface Toy{
    name: string;
}

interface ToyCar extends Car, Toy{
    price:number;
}

```

- Functions 
```typescript
function hello(name:string, age?:number):string{
    if(age!== undefined){
    return `Hello, ${name}. you are ${age}`;
    }
    else{return `Hello, ${name}`}
}

const result = hello('Sam');

console.log(result)



function add(...nums:number[]){
    return nums.reduce((result, num)=>result+num,0)
        }
    
console.log(add(1,2,3));//6

//this
interface User{
    name: string;
}

const Sam:User = {name:'sam'}

function showName(this:User){
console.log(this.name)
}

const a = showName.bind(Sam);
a();

//overload
interface User{
    name: string;
    age: number;
}
function join(name:string,age: number):User;
function join(name:string,age: number|string):User|string{
    if(typeof age === "number"){
        return{
            name,
            age
        };
    } else{
        return "numbers only"
    }
}

const sam:User=join("sam",30); //error: ambiguous type user overload

```

- Literal Types

``` ts
const User1= "bob";
let User2: string | number= "tom";

User2=3;

type Job ="a"|"b"|"c";

//Union Types(or)

interface Car{
    name:"car";
    color: string;
    start():void;
}
interface Mobile{
    name:"mobile";
    color: string;
    call():void;
}

function getGift(gift: Car | Mobile){

    console.log(gift.color);
    if(gift.name === "car"){
    gift.start();}
    else{gift.call();}
}

//Intersection Types(and)

interface Car{
    name:string;
    color: string;
    start():void;
}
interface Toy{
    name: string;
    color: string;
    price: number;
}

const toyCar:Car & Toy={
    name: "Toycar",
    start(){},
    color:"red",
    price: 1000
}











```

