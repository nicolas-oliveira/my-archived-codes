import ApexCharts from 'apexcharts';
import axios from 'axios';

import graphOptions from './libs/graphOptions';
import codigobcb from './common/codigobcb';
import fetchLocal  from './common/fetchLocal';

// Quantidade de acesso a partir do mais recente
let many = '10';

// Formato da query da api do banco central
let query_bcb_api_total = `https://api.bcb.gov.br/dados/serie/bcdata.sgs.${codigobcb.ipca}/dados?formato=json`;
let query_bcb_api_last_indexes = `https://api.bcb.gov.br/dados/serie/bcdata.sgs.${codigobcb.ipca}/dados/ultimos/${many}?formato=json`

let api = [];
let categories = [];
let data = [];

async function getAPIData() {
  try {
		await axios.get(query_bcb_api_total)		
		.then((response) => {
				api = response.data;
				categories = api.map(e => e.data);
				data = api.map(e => e.valor);
			});
		
		if(categories.length == 0 || data.length == 0) {
			api = await fetch(fetchLocal.selic)
			.then(response => {
				 return response.json();
			});

			categories = api.map(e => e.data);
			data = api.map(e => e.valor);
		}
  } catch (error) {
    console.error(error);
  }
}

async function renderGraph() {
  await getAPIData();

  const options = graphOptions(data, categories);
  
  const chart = new ApexCharts(document.querySelector("#charts"), options);
  
  chart.render();
}
renderGraph();