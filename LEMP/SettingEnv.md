# Setting up the environments

## adduser (dont use useradd)
- goto sudoers.d and 90cloud, and set no password required (chmod 777 to modify the file)
- use group and add sudo

## MariaDB installation

MariaDB Server Repositories
- https://mariadb.org/download/?t=repo-config&d=22.04+%22jammy%22&v=10.11&r_m=blendbyte
- install with -secure-installation
- go to maria.conf.d -> server config file
- change port 3306 for security
- comment out bind address
- create database 'dbname'
- GRANT ALL PRIVILEGES ON `dbname`.* TO 'accname'@'%' IDENTIFIED BY 'pwd';'
- fluch privileges
- use HeidiSQL to connect db

- DB dump 
  - mysql -u root -p 'db' > 'filename'
  - mysql -u root -p 'db' < 'filename'

-----

## Composer installation
- https://getcomposer.org/download/

## CI4installation
- https://codeigniter.com/user_guide/installation/installing_composer.html
- install in the root folder
- mv to the folder usr/share/nginx~~
- chmod 777 -r for writable[cap]
- set .env -> mv env .env
- ci_envrionment -> development


## link to php storm
- sftp
- deployment
- root path -> saved location of the proj
- Mappings → Deployment path : / 
- file -> setting -> php -> cli interpreter

