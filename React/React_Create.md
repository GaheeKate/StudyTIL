# React : Create

Today I studied React
- const[value,setValue] = useState(PRIMITIVE); 
   - string,number,boolean,bigint,undefined,symbol,null
- const[value,setValue] = useState(Object); 
   - object, array</br></br>
  
   > newValue = {...value} //copied value</br>
     change newValue</br>
     setValue(newValue)

   > newValue = [...value] //Array



```jsx
import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

function Header(props) {
  return <header>
    <h1><a href="/" onClick={function (event) {
      event.preventDefault();
      props.onChangeMode();
    }}>{props.title}</a></h1>
  </header >
}

function Nav(props) {
  const lis = []
  for (let i = 0; i < props.topics.length; i++) {
    let t = props.topics[i];
    lis.push(<li key={t.id}>
      <a id={t.id}
        href={'/read/' + t.id} onClick={(event) => {
          event.preventDefault();
          props.onChangeMode(Number(event.target.id));
        }}> {t.title}</a >
    </li >) 
  }

  return <nav>
    <ol>
      {lis}</ol>
  </nav>
}


function Article(props) {
  return <article>
    <h2>{props.title}</h2>{props.body}  </article>
}


function Create(props) {
  return <article>
    <h2>Create</h2>
    <form onSubmit={event => {
      event.preventDefault();
      const title = event.target.title.value;// target is form tag
      const body = event.target.body.value;
      props.onCreate(title, body);
    }}>
      <p><input type="text" name="title" placeholder='title' /></p>
      <p><textarea name="body" placeholder='body'></textarea></p>
      <p><input type="submit" value="create"></input></p>
    </form>
  </article>
}



function App() {

  const [mode, setMode] = useState('welcome');
  const [id, setId] = useState(null);
  const [nextId, setNextId] = useState(4);
  const [topics, setTopics] = useState([
    { id: 1, title: "html", body: "Hi, html" },
    { id: 2, title: "css", body: "Hi, css" },
    { id: 3, title: "js", body: "Hi, js" }

  ]);

  let content = null;
  if (mode === 'welcome') {
    content = <Article title='welcome' body="Hi, Web"></Article>
  }
  else if (mode === 'read') {
    let title, body = null;
    for (let i = 0; i < topics.length; i++) {
      if (topics[i].id === id) {
        title = topics[i].title;
        body = topics[i].body;
      }
    }
    content = <Article title={title} body={body}></Article>
  }
  else if (mode === 'create') {
    content = <Create onCreate={(_title, _body) => {
      const newTopic = { id: nextId, title: _title, body: _body }
      const newTopics = [...topics]
      newTopics.push(newTopic);
      setTopics(newTopics);
      setMode('read');
      setId(nextId);
      setNextId(nextId + 1);

    }}></Create>
  }

  return (
    <div>
      <Header title="Web" onChangeMode={() => {
        setMode('welcome');
      }}></Header>
      <Nav topics={topics} onChangeMode={(id) => {
        setMode('read');
        setId(id)
      }}></Nav>
      {content}

      <a href="/create" onClick={(event) => {
        event.preventDefault();//prevent default function of tag
        setMode('create');
      }}>Create</a>
    </div>


  );
}

export default App;


```
