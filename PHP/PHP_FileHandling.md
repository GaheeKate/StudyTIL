File handling: the ability to read and write files on the server. PHP has built in functions for reading and writing files.
### file_exists()

<?php
$file = 'extra/users.txt';

if (file_exists($file)) {
    //echo readfile($file);
    $handle = fopen($file, 'r');
    $contents = fread($handle, filesize($file));
    fclose($handle);
    echo $contents;
} else {
    $handle = fopen($file, 'w');
    $contents = 'Brad' . PHP_EOL . 'Sara' . PHP_EOL . 'Mike' . PHP_EOL;
    fwrite($handle, $contents);
    fclose($handle);
}

### is_file(filename)
##### is_file(string $filename): bool
##### Tells whether the given file is a regular file.

-example from php ci4 

namespace Config;

// Create a new instance of our RouteCollection class.
$routes = Services::routes();

// Load the system's routing file first, so that the app and ENVIRONMENT
// can override as needed.
if (file_exists(SYSTEMPATH . 'Config/Routes.php')) {
    require SYSTEMPATH . 'Config/Routes.php';
}

