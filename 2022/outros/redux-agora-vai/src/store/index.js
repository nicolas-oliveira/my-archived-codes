import { createStore } from "redux";

const INITIAL_STATE = {
  name: "",
  language: "",
};

function reducer(state = INITIAL_STATE, action) {
  if (action.type === "SET_NAME") {
    return {
      ...state,
      name: action.name,
    };
  }

  if (action.type === "SET_LANGUAGE") {
    return {
      ...state,
      language: action.language,
    };
  }
  return state;
}

const store = createStore(reducer);

export default store;
