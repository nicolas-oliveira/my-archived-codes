'use strict';
const React = require('react');
const { render, Text, Box } = require('ink');

class Hello extends React.Component {
  constructor() {
    super();
  }
  render() {
    return (
      <Box flexDirection="column">
        <Box borderStyle="single" borderColor="red">
          <Text bold color="red">
            HELP 2.1
          </Text>
        </Box>
        <Text>help = Comando de ajuda (Este aqui)</Text>
        <Text>helpgit = Comandos do git</Text>
        <Text>Atalhos do help:</Text>
        <Text>/ = Pesquisa e mostra o posterior</Text>
        <Text>? = Pesquisa e mostra o anterior</Text>
        <Text>bashrc = Edita os atalhos aliases</Text>
        <Text>Shift + T = Nova aba</Text>
        <Text>Ctrl + U = Apaga a linha no Começo</Text>
        <Text>Ctrl + A = Começo da linha</Text>
        <Text>man = Guru do Linux</Text>
        <Text>manjaro = Mostra a versão do manjaro</Text>
      </Box>
    );
  }
}
render(<Hello />);
