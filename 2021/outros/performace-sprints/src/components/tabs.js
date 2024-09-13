

// This array define the eval names of tabs
const tabs = [
  { tab: 'tabSprint', chart: 'sprintCharts', name: 'Sprints' },
  { tab: 'tabGain', chart: 'gainCharts', name: 'Ganho' },
];

// Create tabs elements by name and name tab in div 'box'
tabs.map((e) => {
  const newTab = document.createElement('p');
  newTab.innerText = e.name;
  newTab.setAttribute('id', e.tab);
  document.querySelector('.tabs').appendChild(newTab);
});

// Get DOM elements
const tabSprint = document.getElementById('tabSprint');
const tabGain = document.getElementById('tabGain');

// Create events in each element of tabs array
tabs.map((e) => {
  eval(e.tab).addEventListener('click', () => {
      eval(e.tab).style.backgroundColor = tabColors.active;
      eval(e.chart).style.display = 'block';
    tabs.filter((el) => {
      if(e != el) {
        eval(el.tab).style.backgroundColor = tabColors.inactive;
        eval(el.chart).style.display = 'none';
      }
    });
  });
});

// Initialize the tabs: The first interation with [0] array
tabSprint.style.backgroundColor = tabColors.active;

tabs.map((e) => {
  eval(e.tab).addEventListener('mouseover', () => {
    if(eval(e.chart).style.display === 'none')
      eval(e.tab).style.backgroundColor = tabColors.hover;
  });
  eval(e.tab).addEventListener('mouseleave', () => {
    if(eval(e.chart).style.display === 'none')
      eval(e.tab).style.backgroundColor = tabColors.inactive;
  });
});
