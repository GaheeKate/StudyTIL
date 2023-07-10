PHP: -> or =>

-> (= Object Operator)

 is used in object scope to access methods and properties of an object.

 

=> (= Double Arrow Operator)

is used in associative array key value assignment. 

 

 ``` php
<?php
 
$arr1 = array("key1"=>"value1", "key2"=>"value2");
 
echo arr1["key1"]; // value1
echo arr1["key2"]; // value2
 
echo arr1->key1; // This line tries to access the value using object syntax, but since $arr1 is an array and not an object, the syntax is incorrect. It will result in an "undefined" error.
echo arr1->key2; // undefined
 
 
$obj = (object)$arr1; // This line converts the $arr1 array into an object by using type casting. Now, $obj is an object with properties corresponding to the keys and values of the original array.
 
echo obj ->key1; // value1
echo obj ->key2; // value2
 
 
$arr2 = array("key1"->"value1"); // error
$arr2 = array("key1" => "value1"); //  assign the value "value1" to the key "key1".
```


https://stackoverflow.com/questions/14037290/what-does-this-mean-in-php-or
