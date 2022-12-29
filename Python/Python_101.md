# Python : 101

Today I studied Python
- variable: start with '-' or alphabet(case-sensitive)
- import keyword -> keyword.kwlist
- '#' comment out
- 'indentation' instead of {}
- elif:
- 'None' means nothing in there
- complex number
   > c1 = 1+7j
     print(c1.real); print(c1.imag)
     c2=complex(2,3)
     print(c2) # 1.0, 7.0, (2+3j)

- def: define functions
- module : import premade functions in individual files.
- python package: directory
  > from package import module
- Class 
  ``` python
  class MyClass:
     var = "Hi" # class member
     def SayHi(self): # class method, always has 'self 'as a first param
         print(self.var)
    obj=MyClass()
    print(obj.var) #Hi
    obj.sayHi() #Hi
    ```
- Class constructor, destructor
  ``` python
  class Person:
    def __init__(self): #destructor => __del__(self) => del obj
        print("Hi..")

  obj = Person() # Print Hi when instance variable is created. 
  ```

- try, except
  ``` python
  import time
  count = 1
  try:
    while True:
      print(count)
      count+=1
      time.sleep(0.5)
  except KeyboardInterrupt: #ctrl+c
    print('canceled')
  ```

- input
```python
  k=input('input <value>')
  print('your input is <'+k+'>')
```
- slice [1::2] [::-1] backward
- in: if 'a' in msg: 
- lstrip, rstrip, strip