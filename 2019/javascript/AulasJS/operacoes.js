function somar(){
    var numero1 = document.getElementById('number1').value;
    var numero2 = document.getElementById('number2').value;
    var num1 = Number(numero1);
    var num2 = Number(numero2);
    var soma = num1 + num2;
    var result = document.getElementById('resultado');
    result.innerText = 'Resultado: '+ soma;
}

function subtrair(){
    var numero1 = document.getElementById('number1').value;
    var numero2 = document.getElementById('number2').value;
    var num1 = Number(numero1);
    var num2 = Number(numero2);
    var soma = num1 - num2;
    var result = document.getElementById('resultado');
    result.innerText = 'Resultado: '+ soma;
}

function multiplicar(){
    var numero1 = document.getElementById('number1').value;
    var numero2 = document.getElementById('number2').value;
    var num1 = Number(numero1);
    var num2 = Number(numero2);
    var soma = num1 * num2;
    var result = document.getElementById('resultado');
    result.innerText = 'Resultado: '+ soma;
}

function dividir(){
    var numero1 = document.getElementById('number1').value;
    var numero2 = document.getElementById('number2').value;
    var num1 = Number(numero1);
    var num2 = Number(numero2);
    var soma = num1 / num2;
    var result = document.getElementById('resultado');
    result.innerText = 'Resultado: '+ soma;
}