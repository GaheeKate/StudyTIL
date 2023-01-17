# NodeJS : pug

Today I studied NodeJS
- Pug is a template engine for Node and for the browser. 
- A template engine is a program which is responsible for compiling a template (that can be written using any one of a number of languages) into HTML.
- whitespace sensitive, mind the indenting
- npm install nodemon: server auto reload
- Pug doesn’t have any closing tags
- Attributes are added using brackets: <input class="search" type="text" name="search" placeholder="Enter a search term..."/>
- prefix a line with a pipe character (|): 
- Buffered vs Unbuffered Code
  - Unbuffered code starts with a minus (-). It doesn’t directly add anything to the output, but its values may be used from within Pug
  - Buffered code, starts with an equals (=). outputs the result.
- - const employees = ['Angela', 'Jim', 'Nilson', 'Simone']
    > ul
        each employee in employees
          li= employee

    > const employee = {
    'First Name': 'James',
    'Last Name': 'Hibbard'
  }
ul
  each value, key in employee
    li= `${key}: ${value}`

- Conditionals
```js
 -
  const employee = {
    firstName: 'James',
    lastName: 'Hibbard',
    extn: '12345'
  }

#employee
  p= `${employee.firstName} ${employee.lastName}`
  p Extension:
    if employee.extn //check if employee has an extn prop
      =employee.extn
    else
      | n/a

```

