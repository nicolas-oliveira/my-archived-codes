import React from 'react';
import PropTypes from 'prop-types';

function TechItem({ tech, i, onDelete }) {
  return (
    <li>
      { tech }
      <button 
        onClick={ onDelete } 
        type="button" className="remove"
      >
      X
      </button>
    </li>
  );
};

TechItem.defaultProps = {
  tech: 'null',
}

TechItem.propTypes = {
  techs: PropTypes.string,
  onDelete: PropTypes.func.isRequired,
}

export default TechItem;