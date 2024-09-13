var options = {
    chart: {
        height: 450,
        type: 'line',
        zoom: {
            enabled: true
        }
    },
    series: [{
        name: "Date",
        data: [1,1,30,40,4,15,60,10,50,10,23,78,10,10,30,40,40,15,60,10,40,65,90,22,34,60,99,100,100,120,120,100,150,90,120,140,160,199,150,200,223,278]
    }],
    dataLabels: {
        enabled: false
    },
    stroke: {
        curve: 'smooth'
    },
    title: {
        text: 'Números',
        align: 'center'
    },
    grid: {
        row: {
            colors: ['#f3f3f3', 'transparent'], // takes an array which will be repeated on columns
            opacity: 0.5
        },
    },
    xaxis: {
        categories: ['1872','1875','1880','1890','1895','1897','1899','1900','1905','1910','1915','1917','1920','1925','1930','1932','1935','1940','1942','1945','1947','1950','1955','1960','1965','1970','1975','1980','1985','1991','2000','2010','2011','2012','2013','2014','2015','2016','2017','2018',
        '2019','2020'],
    }
}

var chart = new ApexCharts(
    document.querySelector("#chart"),
    options
);

chart.render();