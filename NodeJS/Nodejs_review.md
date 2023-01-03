# NodeJS : review + Mango DB

Today I studied NodeJS
- JS engine: chrome-V8, Mozilla-SpiderMoney, Explorer-Chakra
- V8-> Node.js  
- Event-driven 
- Non-blocking I/O: receive requests first, process the fastest one first
- Good for Social Networking Service, chat 
- easy code, good for prototype
- not ideal if the server is not for web service like image processing server
because library is weak.
- python is good for statistical analysis
- every time when you start a project, npm init and install express
- yarn or npm (yarn add express)
- npm install nodemon: server auto reload

- basic setting for a server 
```js
const express = require('express');
const app = express();

//listening on port 8080
app.listen(8080, () => {

    console.log("listening on port 8080")

});

//get req
app.get('/pet', function (req, res) {
    res.send("hello, this is pet site")
});

//respond with a html file
app.get('/', function (req, res) {
    res.sendfile(__dirname + "/index.html")
});

```

- MongoDB Compass
- show dbs : show all database
- collection(=table) -> document: saved data(=field)
- use studydb
- db.firstcol.insertOne({a:1,arrstr:[{name:John,age:30}]) -> collection.document
- show collections
- rename: db.firstcol.renameCollection('collst')
- delete: db.collst.drop()
- delete all: db.dropDatabase()
- check status: db.enableFreemonitoring()-> copy url and paste it on the browser
- create collection: db.createCollection('coll',{capped:true,size:500})//delete oldest files if the collection has capped. min size is 4096
- check collection status: db.col1.stat
- for(i=0;i<500;i++){
 db.col1.insertOne({a:i})
}

- db.col1.find()
