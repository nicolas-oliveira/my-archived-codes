import React from "react";
import { connect } from "react-redux";

function Output({ name, language }) {
  return (
    <div style={{ background: "blue", padding: "20px", marginTop: "40px" }}>
      <h1>name: {name}</h1>
      <h2>language: {language}</h2>
    </div>
  );
}

export default connect((state) => ({
  name: state.name,
  language: state.language,
}))(Output);
