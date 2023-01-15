# Rest API

Today I studied Rest API

- REST:REST is a Resource Oriented Architecture (ROA) design structure implemented on top of this HTTP protocol. 
  - Uniform Interface, Client-Server, Stateless, Cacheable, A layered system, Code-on-demand
- RESTful: A REST API (also known as RESTful API) is an application programming interface (API or web API) that conforms to the constraints of REST architectural style and allows for interaction with RESTful web services. REST stands for representational state transfer 
  - If API meets all 6 rules, the API is restful

- stateless: A "stateless structure" means that the server's response is independent of the client's session "state". In a stateless structure, the server simply performs the role of sending a response when a request is received and the management of the session is the responsibility of the client. Therefore, a stateless structure is no need to remember the session information with the client and this information is not stored on the server. Instead, it can be stored and managed in an external DB as needed. 1. Session information is not stored on the server, 2. Response irrelevant to session 'State'
- UDT,HTTP: examples of stateless protocol
  - UDT: Regardless of session state, it simply transfers datagrams from source to destination.

- stateful: A "stateful structure" sends a response to the client based on the "state" of the session between the server and the client. To do this, session information including the "state" is stored on the server.
- The TCP 3-way handshake: example of stateful protocol
  - The TCP 3-way handshake is a process used in a TCP/IP network to establish a reliable connection before data is exchanged between applications. Therefore, TCP can be considered stateful as it maintains session information on the server and the server's response can vary based on the session state. 

- cacheable: A cacheable response is an HTTP response that can be cached, that is stored to be retrieved and used later, saving a new request to the server. Cacheable refers to something that can be stored in a cache. In computing, a cache is a temporary storage area where frequently accessed data can be quickly retrieved. When data is cacheable, it can be stored in a cache so that it can be quickly accessed the next time it is needed, rather than having to be retrieved from the original location. This can improve the performance of a system by reducing the amount of time it takes to access frequently used data.