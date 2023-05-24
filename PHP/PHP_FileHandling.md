# File handling: the ability to read and write files on the server. PHP has built in functions for reading and writing files.
### file_exists()
``` php
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
```
### is_file(filename)
##### is_file(string $filename): bool
##### Tells whether the given file is a regular file.

-example from php ci4 
``` php
namespace Config;

// Create a new instance of our RouteCollection class.
$routes = Services::routes();

// Load the system's routing file first, so that the app and ENVIRONMENT
// can override as needed.
if (is_file(SYSTEMPATH . 'Config/Routes.php')) {
    require SYSTEMPATH . 'Config/Routes.php';
}
```

### When encountering issues with file uploads, check if the file size limit is appropriately configured. 

- upload_max_filesize and post_max_size in php.ini: These settings control the maximum size of files that can be uploaded and the maximum size of POST data, respectively. You should verify that these values are set to an appropriate limit that accommodates the file sizes you intend to upload. If the files you are attempting to upload exceed these limits, the upload process will fail.

- client_max_body_size in Nginx configuration (xxx.conf): If you are using Nginx as your web server, it has its own setting called client_max_body_size. This directive determines the maximum allowed size of the client request body, including file uploads. If the file you are trying to upload exceeds this limit, Nginx will reject the request. You can adjust this value in your Nginx configuration to match your desired file size limit.

- CodeIgniter 4 validation - max_size: If you are using CodeIgniter 4 (CI4) as your PHP framework, it provides built-in validation rules for file uploads. The max_size rule allows you to specify the maximum file size allowed for an uploaded file. Make sure you are setting this rule correctly in your validation code to match your desired file size limit. If the uploaded file exceeds the specified max_size, the validation will fail.

- By checking and adjusting these configurations, you can ensure that the file size limits are appropriately set, both at the server level (PHP and Nginx) and within your CodeIgniter 4 application. 
