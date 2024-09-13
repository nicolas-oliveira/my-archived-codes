const {
  setMinutes,
  setSeconds,
  setHours,
  format,
  parseISO,
  getTime,
} = require('date-fns');

const input = Number('1594403628086'); // Date.now() -> unixTimeStamp

const hours = ['08:00', '18:00'];
const pattern = "yyyy-MM-dd'T'HH:mm:ssxxx";

function transformToISO() {
  const hoursISO = hours.map((time) => {
    const [hour, minute] = time.split(':');
    const value = setSeconds(setMinutes(setHours(input, hour), minute), 0); // input seta a data
    return {
      time,
      value,
      sequelizeFormat: format(value, pattern),
    };
  });
  return hoursISO;
}
console.table(transformToISO());

// parseISO('yyyy-MM-dd'T'HH:mm:ssxxx');
console.log(parseISO('2020-03-22')); // Correct date
console.log(parseISO('2020-03-22')); // Correct date
console.log(parseISO('2020-03-22T23:59')); // Correct date
console.log(parseISO('2020-03-22 23:59')); // Correct date??

console.log(parseISO('2020-22-03')); // Invalid date
console.log(parseISO('2020/03/22')); // Invalid date
console.log(parseISO('2020/03/22 23:59')); // Invalid date

// Irá criar uma iso e apenas mudar o que a função se refere:
console.log(setHours(0, 0));
console.log(setMinutes(0, 56));
console.log(setMinutes(0, 56));

const arrOfDates = [
  { iso: '2020-03-22T23:59:04.300Z' },
  { iso: '2020-08-11T23:36:56' },
  { iso: '2020-08-10T08:38:23' },
  { iso: '2020-09-22T12:17:12' },
];

// Date to timestamp
// getTime(parseISO(time.date)
function arrOfDatesToTimestamp() {
  arrOfDates.map((time) => {
    const getTimestamp = getTime(parseISO(time.iso));
    time.timestamp = getTimestamp;
  });
  return arrOfDates;
}

console.table(arrOfDatesToTimestamp());
