import React, { Component } from 'react';
import TechItem from './TechItem';

class TechList extends Component {
  state = {
    newTech: '',
    techs: []
  };

  // Executado assim que o componente aparece em tela
  componentDidMount() {
    const techs = localStorage.getItem('techs');

    if(techs) {
      this.setState({techs: JSON.parse(techs)});
    }
  }

  // Executado sempre que houver alterações nas props ou estado
  componentDidUpdate(prevProps, prevState) {
    if(prevState.techs !== this.state.techs) {
      localStorage.setItem('techs', JSON.stringify(this.state.techs))
    }
  }

  // Executado quando o componente deixa de existir
  // componentWillUnmount() {

  // }

  handleInputChange = e => {
    this.setState({ newTech: e.target.value })
  }

  handleSubmit = e => {
    e.preventDefault();

    this.setState({ 
      techs: [ ...this.state.techs, this.state.newTech ],
      newTech: ''
    });
  }

  handleDelete = index => {
    this.setState({ 
      techs: this.state.techs.filter((tech, i) => i !== index),
    });
  };

  render() {
    return (
      <form onSubmit={ this.handleSubmit }>
        <h1>{ this.state.newTech }</h1>
        <ul>
          { 
            this.state.techs.map((tech, i) =>
              <TechItem 
                key={ i } 
                tech={ tech } 
                onDelete={ () => this.handleDelete(i) }
              />
            )
          }
        </ul>
        <input 
          type="text" 
          onChange={ this.handleInputChange } 
          value={ this.state.newTech }
        />
        <button type="submit">Enviar</button>
      </form>
    )
  }
}
export default TechList;