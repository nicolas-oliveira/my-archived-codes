function plotAllData(jsonData) {
  const eixoY = jsonData.filter((year) => year);
  const eixoX = jsonData.filter((sells) => sells);

  const keys = Object.keys(jsonData[0]);

  const options = {
    chart: {
      type: "bar",
    },
    series: [
      {
        name: keys[0],
        data: [30, 40, 35, 50, 49, 60, 70, 91, 125],
      },
    ],
    xaxis: {
      categories: [1991, 1992, 1993, 1994, 1995, 1996, 1997, 1998, 1999],
    },
  };

  const chart = new ApexCharts(document.querySelector("#chart"), options);

  chart.render();
}
