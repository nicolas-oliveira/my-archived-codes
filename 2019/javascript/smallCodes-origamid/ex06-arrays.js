const arr1 = ['F1', 'F2', 'F3'];
const arr2 = ['A!', 'A@', 'A#'];

let newArr = arr1.concat(arr2);
console.log(`${newArr}`);

const numbers = [11, 22, 56, 98, 1, 34, 77, 1100, 234, 0, -1, -45, 0.01];
const negativeNumbers = numbers.filter((arr)=>{
    return arr < 0;
});
console.log(`\n${negativeNumbers}`);

const higherThen100 = numbers.filter((arr)=>{
    return arr > 100;
})
console.log(`${higherThen100}`);

newerArr = negativeNumbers.concat(higherThen100);
console.log(`\n${newerArr}`);