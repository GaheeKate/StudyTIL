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


