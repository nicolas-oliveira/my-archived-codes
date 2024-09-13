import React from 'react';
import '../styles/Header.css';
import FacebookLogo from '../../images/facebook.png';
import AccountIcon from '../icons/AccountIcon';

class Header extends React.Component {
  render() {
    return (
      <div className="header">
        <img src={ FacebookLogo } alt="Logo" />
        <div className="profile">
          <h3>Meu perfil</h3>
          <AccountIcon />
        </div>
      </div>
    );
  }
}

export default Header;