import React from "react";
import Header from './components/Header';
import PostList from './components/PostList';
import './styles/App.css';

class App extends React.Component {
  render() {
    return (
      <div>
        <Header />
        <PostList />
      </div>
    );
  }
};

export default App;