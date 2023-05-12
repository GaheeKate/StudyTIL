SSH Login in with id and password


go to /etc/ssh/
and open sshd_config

change passwordauthentication to yes

and go to cloud conf
and change the same option to yes

addtionally change the port for security

service sshd restart

set a password with passwd

