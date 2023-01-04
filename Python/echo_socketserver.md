# Python : Echo server/ Client  + file transfer

Today I studied Python using socket module

- socketserver : is a web framework for network server
  - socketserver has 4 server class
    - socketserver.TCPServer Class
    - socketserver.UDPServer Class .. 

``` python
import socketserver

HOST = ''
PORT = 9009


class MyTcpHandler(socketserver.BaseRequestHandler):
    # initialized only once per server.
    # Implement logic for client connection handling in handle() method.
    def handle(self):
        print('[%s] connected' % self.client_address[0])

        try:
            while True:
                self.data = self.request.recv(1024)
                if self.data.decode() == '/quit':  # stop the server if the msg '/quit' is received
                    print('stopped by [%s]' % self.client_address[0])
                    return

                print('[%s]' % self.data.decode())
                self.request.sendall(self.data)
        except Exception as e:
            print(e)


def runServer():
    print(
        '+++starting echo server'
    )

    try:
        server = socketserver.TCPServer((HOST, PORT), MyTcpHandler)
        server.serve_forever()
    except KeyboardInterrupt:
        print(
            '+++finishing echo server'
        )


  ```


- echo client
``` python
import socket

HOST = 'localhost'
PORT = 9009

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
    sock.connect((HOST, PORT))
# client is keep running until the msg '/quit' has typed.
    while True:
        msg = input('message: ')
        if msg == '/quit':
            sock.sendall(msg.encode())
            break
        sock.sendall(msg.encode())
        data = sock.recv(1024)
        print('data received from server [%s]' % data.decode())

print('client has closed')


  ```



- server for sending files


``` python
import socketserver
from os.path import exists


HOST = ''
PORT = 9009


class MyTcpHandler(socketserver.BaseRequestHandler):

    def handle(self):
        data_transferred = 0  # for saving size of data transferred
        print('[%s] connected' % self.client_address[0])
        filename = self.request.recv(1024)
        filename = filename.decode()

        if not exists(filename):
            return

        print('start file [%s] sending..' % filename)
        with open(filename, 'rb') as f:
            try:
                data = f.read(1024)
                while data:
                    data_transferred += self.request.send(data)
                    data = f.read(1024)
            except Exception as e:
                print(e)

        print('sending file [%s] completed, data transferred [%d]' % (
            filename, data_transferred))


def runServer():
    print(
        '+++starting echo server'
    )

    try:
        server = socketserver.TCPServer((HOST, PORT), MyTcpHandler)
        server.serve_forever()
    except KeyboardInterrupt:
        print(
            '+++finishing echo server'
        )


runServer()

  ```


- client for receiving files


``` python
import socket

HOST = 'localhost'
PORT = 9009


def getFileFromServer(filename):
    data_transferred = 0

    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        sock.connect((HOST, PORT))
        sock.sendall(filename.encode())

        data = sock.recv(1024)
        if not data:
            print(
                'file [%s] is not exist in the server or error occurred' % filename)
            return

        with open('download/'+filename, 'wb') as f:
         # save files in download folder.
            try:
                while data:
                    f.write(data)
                    data_transferred += len(data)
                    data = sock.recv(1024)
            except Exception as e:
                print(e)

    print('file [%s] download completed, received [%d]' %
          (filename, data_transferred))


filename = input('input the name of the file that you want to download: ')
getFileFromServer(filename)


  ```
