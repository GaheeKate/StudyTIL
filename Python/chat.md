# Python : Chat server/client

Today I studied Python 

- Asynchronous handling


- chat server
``` python
import socketserver
import threading

HOST = ''
PORT = 9009
# allow only one process or thread. lock other process or thread when data is being edited.
lock = threading.Lock()


class UserManager:
    def __init__(self):
        self.users = {}  # contains user's information

    def addUser(self, username, conn, addr):
        if username in self.users:
            conn.send('Registered username.\n'.encode())
            return None

    # register new user
        lock.acquire() #lock it before adding username
        self.users[username] = (conn, addr)
        lock.release() #after update release

        self.sendMessageToAll('user [%s] has entered the room' % username)
        print('+++Current user count: [%d]' % len(self.users))

        return username

    def removeUser(self, username):
        if username not in self.users: #if username is not exists return
            return

        lock.acquire()
        del self.users[username]
        lock.release()

        self.sendMessageToAll('user [%s] left the room' % username)
        print('+++Current user count: [%d]' % len(self.users))

    def messageHandler(self, username, msg):
        if msg[0] != '/': # if the first letter is not '/' ,send msg and username to all and return
            self.sendMessageToAll('[%s] %s' % (username, msg))
            return
        if msg.strip() == '/quit': #if msg is '/quit' call removeuser func and remove username from self.users and return -1
            self.removeUser(username)
            return -1

    def sendMessageToAll(self, msg): #send msg to all connected clients
        for conn, addr in self.users.values():
            conn.send(msg.encode())


class MyTcpHandler(socketserver.BaseRequestHandler):
    userman = UserManager()

    def handle(self):#print client address
        print('[%s] connected' % self.client_address[0])

        try:
            username = self.registerUsername()#call registerusername() and register user 
            msg = self.request.recv(1024)#receive msg from client 
            while msg:
                print(msg.decode())
                #if return value is -1, close request and break while loop
                if self.userman.messageHandler(username, msg.decode()) == -1:
                    self.request.close()
                    break
                msg = self.request.recv(1024)

        except Exception as e:
            print(e)

        print('[%s] connection closed' % self.client_address[0])
        self.userman.removeUser(username)# remove user when connection is closed

    def registerUsername(self):# receive user Id and register
        while True:
            self.request.send('Login Id: ' .encode())
            username = self.request.recv(1024)
            username = username.decode().strip() #remove empty spaces in both end side 
            if self.userman.addUser(username, self.request, self.client_address):
                return username


class ChatingServer(socketserver.ThreadingMixIn, socketserver.TCPServer):
    pass


def runServer():
    print(
        '+++starting chatting server'
    )

    try:
        server = socketserver.TCPServer((HOST, PORT), MyTcpHandler)
        server.serve_forever()
    except KeyboardInterrupt:
        print(
            '+++finishing chatting server'
        )
        server.shutdown()
        server.server_close


runServer()



  ```

- chat client
- blocking mode: wait until the process has finished when the function accept(), recv(), send() has called.
- blocking mode can be released by setblocking(0)
``` python
import socket
from threading import Thread

HOST = 'localhost'
PORT = 9009


def rcvMsg(sock):#receive msg from the server and print 
    while True:
        try:
            data = sock.recv(1024)
            if not data:
                break
            print(data.decode())
        except:
            pass


def runChat():#create a socket and connect to chat server, run rcvmsg(). receive msg from client and sent it to the server 
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        sock.connect((HOST, PORT))
        t = Thread(target=rcvMsg, args=(sock,))#make rcvmsg() a individual thread and send args to sock
        t.daemon = True#when main thread is finished, close this thread
        t.start()#run thread t

        while True:
            msg = input()
            if msg == '/quit':
                sock.send(msg.encode())
                break
            sock.send(msg.encode())


runChat()

  ```

