# Javascript : 1

Today I studied Javascript

- object literal 
  > let user={
    name:'Mike',
    age:30,
  }

- constructor function(=object maker)
  > function User(name,age){
    //this={}
    this.name = name;
    this.age=age;
    //return this;
  } 

  let user1 = new User('Mike',30); 
  //new function works on any functions, so we start with a capital letter for constructor function for clarification.

- computed property
  > let a = 'age'
    const user = {
      name = 'Mike',
      [a] : 30

    }

- object Methods
  - Object.assign(): duplicate object
    > const newUser = Object.assign({},user);
  - Object.keys(): return keys in an array
  - Object.values(): return values in an array
  - Object.entries(): return both keys and values in an array
      > [["key","value"],["key","value"],["key","value"],]
  - Object.fromEntries()= array to object

- Symbol
  > const a = Symbol(); // not attaching new, unique
- Symbol.for(): Only one symbol can be guaranteed. Share same symbols. An existing symbol with the given key if found; otherwise, a new symbol is created and returned.
  > const id1= Symbol.for('id');
    Symbol.keyFor(id1)//"id"
- .description
- Object.getOwnPropertySymbols(user);: to see hidden Symbol key

- arr.sort();
  > arr.sort((a,b)=>{
      return a - b;
    })
    or
    Lodash
    .sortBy(arr);

- arr.reduce();
  > let userList=[{name:"Mike", age:30},{name:"Tom", age:20},{name:"Jane", age:40}]
    let result = userList.reduce((prev, cur)=>{
      prev.push(cur.name);
    return prev;
  },[])