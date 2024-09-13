const colors = {
	blue: "#4793C9",
	white: '#c3c0bd',
	black: '#545455',
}

export default (data, categories) => {
	return {
		chart: {
			type: 'line',
			foreColor: colors.white,
			height: '100%',
			zoom: {
				autoScaleYaxis: true
			},
			animations: {
				enabled: false,
			}
		},
		series: [{
			name: 'IPCA',
			data: data,
			xaxis: {
				tickAmount: 6,
			}
		}],
		colors: [colors.blue],
		xaxis: {
			type: 'datatime',
			categories: categories,
			tickAmount: 6,
		},
		dataLabels: {
			enabled: false
		},
		tooltip: {
			theme: 'dark'
		},
		grid: {
			show: true,
			borderColor: colors.black,
		}
	}
};