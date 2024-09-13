// import axios from 'axios';


// import processData from './lib/processSelicData';
// http://api.bcb.gov.br/dados/serie/bcdata.sgs.11/dados?formato=json
// async function axiosTest() {
//   try {
//     const response = await fetch('https://jsonplaceholder.typicode.com/users');
//     const body = await response.body;
//     console.log(response);
//   } catch (error) {
//     console.error(error);
//   }
// }
// axiosTest();
// const data = api.map(e => {

// })

import express, { response } from 'express';
import axios from 'axios';
import cors from 'cors';

const app = express();
app.use(cors());
app.use(express.json());

app.get('/', async (request, res) => {
  const api = await axios.get('http://api.bcb.gov.br/dados/serie/bcdata.sgs.11/dados?formato=json').then(
    (response) => {
     console.log(response);
    }
  );
[]
});

app.listen('3333');