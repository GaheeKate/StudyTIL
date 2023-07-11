# SQL_placeholder

## Question Mark ('?') Placeholder:
The question mark '?' is commonly used as a placeholder in SQL queries, especially with programming languages that support parameterized queries or prepared statements. When using the '?' placeholder, you typically bind values to the parameters in the order they appear in the query. 

```php
function sample($asdf) {
    $sql = 'SELECT a.id FROM sample a WHERE a.id= :aIdx:';
    $query = $this->db->query($sql, ['aIdx' => $asdf]);
}
``` 
-----

## Colon (':') Placeholder:
It allows you to assign a name or label to a placeholder, providing more flexibility when binding values to the parameters. It is more readable. May not be  It is more readable. may not be supported in some frameworks.in some frameworks.

``` php

function sample($asdf) {
    $sql = 'SELECT a.id FROM sample a WHERE a.id = :aIdx:'; // :start :end
    $query = $this->db->query($sql, ['aIdx' => $asdf]);
}
```
