#define() and defined()

## The `defined()` function is used to check if a constant has been defined and returns a boolean value. On the other hand, the `define()` function is used to define constants.

## By utilizing `define()` and `defined()`, direct access thru URL can be prevented.

This code serves as a preventive measure to block direct access to the `login.php` file when it is intended to be included and used within the `index.php` file for handling login functionality.

In the `index.php` file, the `define()` function is used to define a constant:

```php
define('ALLOWED', true);
include_once('login.php');
```

In the `login.php` file, the `defined()` function is used to check if the constant has been defined:

```php
if (!defined('ALLOWED')) exit;
```

When the `login.php` file is loaded, if the `ALLOWED` constant is not defined as `true`, the `exit` statement is executed. This means that if a user directly accesses the URL of `login.php` without going through `index.php`, the `ALLOWED` constant will not be defined, causing the script execution to be terminated with `exit`.

