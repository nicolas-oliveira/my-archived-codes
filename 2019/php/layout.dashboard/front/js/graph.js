var options = {
    chart: {
      height: 280,
      type: "line",
      foreColor: '#f2feff'
    },   
    dataLabels: {
      enabled: false
    },
    series: [
      {
        name: "Series 1",
        data: [134, 35, 33, 145, 69, 73, 312]
      }
    ],
    colors: ['#fb5fa0', '#fb5fa0', '#fb5fa0'],
    stroke: {
        curve: 'smooth'
    },
    xaxis: {
      categories: [
        "01 Jan",
        "02 Jan",
        "03 Jan",
        "04 Jan",
        "05 Jan",
        "06 Jan",
        "07 Jan"
      ]
    }
  };
  
  var chart = new ApexCharts(document.querySelector("#chart"), options);
  
  chart.render();
  