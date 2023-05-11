# Nginx
## Installing without prerequisites
Based on https://nginx.org/en/linux_packages.html

```
curl https://nginx.org/keys/nginx_signing.key | gpg --dearmor | sudo tee /usr/share/keyrings/nginx-archive-keyring.gpg >/dev/null

sudo apt-key list /usr/share/keyrings/nginx-archive-keyring.gpg | grep -q 573BFD6B3D8FBC641079A6ABABF5BD827BD9BF62 || sudo rm /usr/share/keyrings/nginx-archive-keyring.gpg
//use apt-key to verify the downloaded key and remove
//if you dont want to verify the key at all, just delete this second line.

echo "deb [signed-by=/usr/share/keyrings/nginx-archive-keyring.gpg] http://nginx.org/packages/ubuntu $(lsb_release -cs) nginx" | sudo tee /etc/apt/sources.list.d/nginx.list

echo -e "Package: *\nPin: origin nginx.org\nPin: release o=nginx\nPin-Priority: 900\n" | sudo tee /etc/apt/preferences.d/99nginx

sudo apt update
sudo apt install nginx
```
---
or this:

https://www.nginx.com/resources/wiki/start/topics/tutorials/install/

e.g. Ubuntu 20.04 (Focal Fossa):

/etc/apt/sources.list.d/, such as /etc/apt/sources.list.d/nginx.list

```
deb https://nginx.org/packages/ubuntu/ focal nginx 
deb-src https://nginx.org/packages/ubuntu/ focal nginx
```

```
sudo apt-key adv --keyserver keyserver.ubuntu.com --recv-keys $key
sudo apt update
sudo apt install nginx
```


```
sudo systemctl start nginx
```
