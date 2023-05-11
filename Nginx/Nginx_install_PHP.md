# Install PHP on Nginx
## before starting, have the latest version of Nginx
- apt-get update -y
- apt-get upgrade -y

## apt list |grep fpm
- check the fpm lists that can be installed 

//"--no-install-recommends" option, the user lets apt-get know not to consider recommended packages as a dependency to install

## install PHP with modules 
- sudo apt install php8.1-fpm php8.1 php8.1-common php8.1-mysql php8.1-xml php8.1-xmlrpc php8.1-curl php8.1-gd php8.1-imagick php8.1-cli php8.1-imap php8.1-mbstring php8.1-opcache php8.1-soap php8.1-zip php8.1-intl php8.1-bcmath unzip -y

- php-fpm: FastCGI Process Manager
- php-common: PHP configuration files
- php-xmlrpc: PHP script to make remote procedure calls (RPC) using the XML-RPC protocol.
- php-curl:PHP scripts to make HTTP requests and interact with other web services or APIs using the CURL library.
- php-gd: A package that adds support for the GD Graphics Library to PHP. This package provides a set of functions that can be used to create and manipulate images, including resizing, cropping, and adding text or watermarks.
- php-imagick: A package that adds support for the ImageMagick image manipulation library to PHP. This package provides a set of classes and functions that can be used to create and manipulate images, including resizing, cropping, and adding effects or filters.
- php-cli: A package that provides a command-line interface (CLI) for PHP. This package allows PHP scripts to be run from the command line, and provides a set of tools and utilities for working with PHP from the terminal.
- php-imap: A package that adds support for the IMAP email protocol to PHP. This package provides a set of functions that can be used to read and manipulate email messages on an IMAP server.
- php-mbstring: A package that adds support for multibyte character encoding to PHP. This package provides a set of functions that can be used to work with multibyte character sets, including string manipulation, regular expressions, and more.
- php-opcache: A package that provides a bytecode cache for PHP. This package improves the performance of PHP scripts by caching compiled PHP code in memory, reducing the need to recompile PHP scripts on each request.
- php-soap: A package that adds support for the SOAP protocol to PHP. This package provides a set of classes and functions that can be used to create and consume SOAP web services.
- php-zip: A package that adds support for ZIP archives to PHP. This package provides a set of functions that can be used to create, read, and extract ZIP archives.
- php-intl: A package that adds support for internationalization and localization to PHP. This package provides a set of functions and classes that can be used to work with different languages, date and time formats, and other cultural conventions.
- php-bcmath: A package that provides support for arbitrary precision mathematics in PHP. This package provides a set of functions that can be used to perform mathematical operations with arbitrarily large numbers.

//log -> /var/log/nginx/ tail error.log

## link configuration  
- add root : root /usr/share/nginx/html
- go to /etc/nginx/conf.d default.conf
- use socket
```
    location ~* \.php$ {
            fastcgi_pass unix:/run/php/php8.1-fpm.sock;
            fastcgi_index index.php;
            fastcgi_param SCRIPT_FILENAME $document_root$fastcgi_script_name;
            include fastcgi_params;
    }

```


## test 
- create index.php under share/nginx/html

```
<?php
phpinfo();
?>
```

- because index.php will be placed in share/nginx, gotta change the owner from www/html to nginx in the config
- goto :/etc/php/8.1/fpm/pool.d# vim www.conf
```
;user = www-data
;group = www-data
user = nginx
group = nginx

;listen.owner = www-data
;listen.group = www-data
listen.owner = nginx
listen.group = nginx

```


service nginx restart
systemctl restart php8.1-fpm

