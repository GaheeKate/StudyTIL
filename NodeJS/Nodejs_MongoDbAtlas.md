# NodeJS : Mango DB Authentication+ Mango DB Atlas

Today I studied Mango DB 
- use admin: switch to the admin
- db.createUser({user:"admin", pwd:"test",roles:[{role:"userAdminAnyDatabase", db:"admin"}]})
- db.adminCommand({shutdown:1}) : connection close
- force authentication by changing the config file
```
security:
  authorization: enabled
```
- service->mongodbserver restart

- add a specific user for the database
    - mongosh --port 27017 -u "admin" authenticationDatabase "admin" -p
    - use testdb
    - db.creatUser({user: "testdbuser" , pwd: "test", roles:[{role: dbOwner, db:"testdb"}]})
