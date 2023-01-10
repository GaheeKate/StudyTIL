# Node.js : Create

Today I studied Node.js

- BLOCKING: must executed in order. Blocking is when the execution of additional JavaScript in the Node.js process must wait until a non-JavaScript operation completes.
- NON-BLOCKING SCRIPT
  - Event handler is an example of non-blocking code 
  - executed asynchronously



- 3 ways of creating objects
  - new object
  - object literal notation
  - prototype: start with function. prototype is like genes of the function object. 



- OBJECT LITERAL SYNTAX: An object literal is a comma-separated list of name-value pairs inside of curly braces.

- MODULE DESIGN PATTERN: JavaScript doesn't offer Access modifiers. The Module pattern was originally defined as a way to provide both private and public encapsulation for classes in conventional software engineering.
 they can be easily exported or imported into other files.
 prevent conflicts between classes or function names included in different modules.
 (https://www.patterns.dev/posts/classic-design-patterns/#modulepatternjavascript)


- privacy: protecting pieces from leaking into the global scope and accidentally colliding with another developer's interface
The pattern utilizes an immediately-invoked(run) function expression (IIFE - see the section on namespacing patterns for more on this) where an object is returned.


- Export: allows you to provide access to module features outside the module.
- Import: allows us to import bindings that are exported by a module to our script.