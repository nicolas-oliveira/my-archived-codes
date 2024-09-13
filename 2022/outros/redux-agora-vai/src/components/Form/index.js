/* eslint-disable no-unused-vars */
import React, { useState } from "react";
import { connect } from "react-redux";

function setName(name) {
  return {
    type: "SET_NAME",
    name,
  };
}

function setLanguage(language) {
  return {
    type: "SET_LANGUAGE",
    language,
  };
}

function Form({ name, language, dispatch }) {
  // console.log({ name, selectedLanguage });

  return (
    <>
      <label htmlFor="fname">First name:</label>
      <br />
      <input
        type="text"
        id="fname"
        name="fname"
        onChange={(e) => dispatch(setName(e.target.value))}
      />
      <br /> {" "}
      <input
        type="radio"
        id="html"
        name="fav_language"
        value="HTML"
        onChange={(e) => dispatch(setLanguage(e.target.value))}
      />
        <label htmlFor="html">HTML</label>
      <br /> {" "}
      <input
        type="radio"
        id="css"
        name="fav_language"
        value="CSS"
        onChange={(e) => dispatch(setLanguage(e.target.value))}
      />
        <label htmlFor="css">CSS</label>
      <br /> {" "}
      <input
        type="radio"
        id="javascript"
        name="fav_language"
        value="JavaScript"
        onChange={(e) => dispatch(setLanguage(e.target.value))}
      />
        <label htmlFor="javascript">JavaScript</label>
    </>
  );
}

export default connect((state) => ({
  name: state.name,
  language: state.language,
}))(Form);
