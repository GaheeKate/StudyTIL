# Javascript : Encryption_Jasmine 

Today I studied Javascript


- Behavior Driven Development(BDD)
  - Follows Test driven development philosophy
  - should be written in plain English and understandable by non-programmers

- Unit test pattern
  - function test(testValue, expectation)

- Jasmine "Spec"
  - expect(checkId(testid).toEquel(true))
- Jasmine doesn't have access to document object


- test.js
``` js
function helloWorld(){
  "use strict";
  return "Hello World.";
} 
```
- spec.js
``` js
describe("Example suite", function(){
 it("should add 2 plus 2",function(){
     expect(2 + 2).toEqual(4);
 })
});
 
describe("Example suite", function(){
 it("should add 2 plus 2",function(){
     expect(helloWorld()).toEqual("Hello World."); //not.toEqual
 })
});
```

- specRunner.html
  - add source.js and spec.js files
