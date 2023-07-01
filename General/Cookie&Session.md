# Session & Cookie

HTTP

HTTP is a protocol that is both connectionless and stateless. These characteristics are designed to optimize server resources by establishing and terminating connections for each user request, without maintaining a persistent connection or storing state information after the connection is terminated.

Session

A session ID is generated for each web browser and stored in the web container. It gets destroyed when the browser is closed. A new session is created when a user logs out, treating them as a new user. Storing client information in the session eliminates the need to access the database for every request, making it more efficient.

Cookie

A cookie is a temporary file that contains information generated when a user accesses a website. It is a piece of data that the server stores on the user's web browser. The data in a cookie is structured in the form of key-value pairs and is typically composed of strings.Cookies can potentially be used to track user activities and gather personal information. This raises privacy concerns

Cookies are utilized to store user-convenience information like auto-fill data or "do not show again" preferences. It is important to note that cookies should only contain non-sensitive information that can be safely deleted or manipulated without major consequences. On the other hand, for handling crucial information that must remain confidential and secure, server-side sessions are employed to ensure it is not exposed to users or intercepted by unauthorized parties.

To verify and identify users using cookies and sessions:

1. When a user first visits a website, the server generates a unique session ID and sends it to the client as a cookie. This session ID is stored on the client-side.
2. On subsequent requests from the client, the stored session ID is sent back to the server as a cookie in the request headers.
3. The server receives the session ID and uses it to retrieve the corresponding session data stored on the server. This session data typically includes user-specific information such as login credentials or user preferences.
4. The server compares the session data with the requested resource or action to verify the user's identity. If the session data matches the expected user information, the user is considered authenticated and authorized to access the requested resource.
5. If the session data does not match or is missing, the server may redirect the user to a login page or deny access to the requested resource.
