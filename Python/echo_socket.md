# Python : Echo server/ Client 


Today I studied Python using socket module

- Network socket : A socket is an endpoint of a two-way communication link between two programs running on the network.
  - TCP socket: A socket programming interface provides the routines required for interprocess communication between applications. used to transport messages in the network
  - UDP socket: User datagram protocol (UDP) is used for time-critical data transmissions such as DNS lookups, online gaming, and video streaming.
  - Raw: A raw socket is a type of socket that allows access to the underlying transport provider. for router or network gear</br></br>
  
- echo server

``` python
import socket

# used for binding IP and Port
HOST = ''  # bind func auto assigns IP
PORT = 9009


def runServer():
    # create TCP socket and return socket obj
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
        sock.bind((HOST, PORT))
        sock.listen(1)  # process one at a time. available to set to 5
        print('Waiting for client connection..')
        conn, addr = sock.accept()
        with conn:
            print('connected with [%s]' % addr[0])
            while True:
                data = conn.recv(1024)  # size of buffer. set 1024 ~ 4096
                if not data:
                    break
                print('msg received[%s]' % data.decode())
                conn.sendall(data)  # send received data to client

runServer()

  ```


- echo client
  - tcp client
    - socket.socket()-> connect-> send-> recv-> close
``` python
import socket

HOST = 'localhost'
PORT = 9009

with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as sock:
    sock.connect((HOST, PORT))
    msg = input('message: ')
    sock.sendall(msg.encode())
    data = sock.recv(1024)

print('data received from server [%s]' % data.decode())


runServer()

  ```
