# Trait

Traits were introduced in PHP 5.4 and are used to reuse and combine code within classes.

Traits can be considered as a collection of class members (variables and methods) and allow code reuse in PHP, which does not support multiple inheritance. Traits are declared using the trait keyword.

With traits, you can include methods from other classes directly into the current class. This helps to avoid code duplication and easily share common functionality between classes.

Here's a simple example of using traits in PHP:

```php

trait Logger {
public function log($message) {
echo "Logging message: $message";
}
}

class User {
use Logger;

    public function register() {
        // User registration logic
        $this->log('User registered');
    }

}

$user = new User();
$user->register(); // Outputs "Logging message: User registered"
```

In the above example, the Logger trait contains the log() method, and it is included in the User class using the use keyword. This allows the User class to use the log() method.

Traits can be used in other traits or classes, and multiple traits can be combined in a single class.
