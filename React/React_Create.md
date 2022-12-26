# React : Read

Today I studied React
- Component: User defined tag, Can reduce repeated codes
- props: Give attributes to components
- event: a tag in component is not same with a tag in html. react convert code to html. onclick in html and onClick(function) is different
- state: props(outside) is used to pass data between components and state(inside) is the local state of the component 


```jsx
import logo from './logo.svg';
import './App.css';
import { useState } from 'react';

//cant update every variable hence use useState to update variables to be updated
//react is about creating user defined tag(component)
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
      <a id={t.id} /*id was number but changed to string*/
        href={'/read/' + t.id} onClick={(event) => {
          event.preventDefault();
          props.onChangeMode(Number(event.target.id))/*convert to number*/;
        }}> {t.title}</a >
    </li >)//unique key in for loop
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

function App() {
  /*const _mode = useState('welcome');// default value
  const mode = _mode[0] // read state
  const setMode = _mode[1] //set state*/

  const [mode, setMode] = useState('welcome');
  const [id, setId] = useState(null);


  const topics = [
    { id: 1, title: "html", body: "Hi, html" },
    { id: 2, title: "css", body: "Hi, css" },
    { id: 3, title: "js", body: "Hi, js" }

  ]

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

    </div>


  );
}

export default App;

```