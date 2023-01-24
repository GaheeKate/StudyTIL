# MongoDB

Today I studied MongoDB
- MongoDB is a document based database.
- It uses JSON to store data
  - Collections = tables
  - Documents = rows
- mongosh

- use <your_db_name> : create a new database and select
- db.createCollection("menuLinks"): Create a collection
- db.menuLinks.insert({ "weight": 0, "path": "/", "name":
"Home" }):insert data to the collection
d. You can try checking all the data/documents in the collection:
- db.menuLinks.find({}):check data/document. ({}) is equivalent of * in SQL
- _id field serves as the index(primary key)

Useful commands are:
- find()
- findOne()
- insertOne()
- insertMany()
- updateOne()
- deleteOne()
(https://docs.mongodb.com/mongodb-shell/crud/#std-label-mdb-shell-crud)
</br>

- To import modules/libraries:
>const { MongoClient } = require("mongodb");
const dbUrl = "mongodb://localhost:27017/databasename"; //default port is 27017
const client = new MongoClient(dbUrl);

- async function to make a connection and return the database
>async function connection() {
await client.connect();
db = client.db("testdb");
return db;
}
- async function to retrieve the data from the collection
>async function getLinks() {
db = await connection();
var results = db.collection("menuLinks").find({});
res = await results.toArray();
return res;
}

- async/await
  - request as an async function
  - within the function, use await to retrieve any results of an asynchronous request.
